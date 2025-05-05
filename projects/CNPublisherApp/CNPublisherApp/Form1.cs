using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using NetMQ;
using NetMQ.Sockets;
using System.ServiceModel.Channels;
using System.Threading.Channels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace CNPublisherApp
{
    public partial class Form1 : Form
    {
        private PublisherSocket publisher;
        public string weatherDesc;
        public Form1()
        {
            InitializeComponent();
            try
            {
                string localIP = GetLocalIPAddress();
                publisher = new PublisherSocket();
                publisher.Bind($"tcp://{localIP}:12345");
                MessageBox.Show($"Publisher başlatıldı: {localIP}:12345");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PublisherSocket error: " + ex.Message);
            }
        }


        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("IPv4 adresi bulunamadı!");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] userNames = { "All", "Ahmet", "Mehmet", "Berat", "Esen" };
            foreach (string user in userNames)
            {
                comboBox2.Items.Add(user);
            }
            comboBox2.SelectedIndex = 0;
            string[] turkishCities = {
        "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
        "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
        "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir",
        "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Isparta", "Mersin", "İstanbul", "İzmir",
        "Kars", "Kastamonu", "Kayseri", "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
        "Manisa", "Kahramanmaraş", "Mardin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya",
        "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
        "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak",
        "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"
            };

            foreach (string city in turkishCities)
            {
                comboBox1.Items.Add(city);
            }

            comboBox1.SelectedIndex = 0; 

            LoadWeatherDataAsync(comboBox1.SelectedItem.ToString());
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedCity = comboBox1.SelectedItem.ToString();
            LoadWeatherDataAsync(selectedCity);
        }

        private async Task LoadWeatherDataAsync(string city)
        {
            try
            {
                string api = "15c2392b22b3a992cddd1de0f69d4dc7";
                string connection = $"http://api.openweathermap.org/data/2.5/weather?q={city}&mode=xml&lang=tr&units=metric&appid={api}";

                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(connection);
                    XDocument weather = XDocument.Parse(response);

                    var temperature = weather.Descendants("temperature").FirstOrDefault();
                    var weatherState = weather.Descendants("weather").FirstOrDefault();
                    var humidity = weather.Descendants("humidity").FirstOrDefault();
                    var windSpeed = weather.Descendants("speed").FirstOrDefault();
                    var cityName = weather.Descendants("city").FirstOrDefault();

                    if (temperature != null && weatherState != null && humidity != null && windSpeed != null && cityName != null)
                    {
                        var temp = temperature.Attribute("value").Value;
                        weatherDesc = weatherState.Attribute("value").Value;
                        var hum = humidity.Attribute("value").Value;
                        var speed = windSpeed.Attribute("value").Value;
                        var cityId = cityName.Attribute("id").Value;
                        var cityNameValue = cityName.Attribute("name").Value;

                        label1.Text = $"{cityNameValue} tempature: {temp}°C";
                        label2.Text = $"{cityNameValue} state: {weatherDesc}";
                        label5.Text = $"Humidity: {hum}%";
                        label6.Text = $"Wind: {speed} m/s";
                    }
                    else
                    {
                        label1.Text = "weather null.";
                        label2.Text = "city cant found.";
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "weather data null.";
                label2.Text = "error: " + ex.Message;
            }
        }




        private void buttonSend_Click(object sender, EventArgs e)
        {
            string selectedCity = comboBox1.SelectedItem?.ToString();
            string temperature = label1.Text;
            string customMessage = textBox2.Text;

            if (!string.IsNullOrEmpty(selectedCity) && publisher != null)
            {
                string message = $"{selectedCity}: {temperature}:{weatherDesc}";
                if (!string.IsNullOrWhiteSpace(customMessage))
                {
                    message += $"\nNote: {customMessage}";
                }
                publisher.SendMoreFrame("All").SendFrame(message);
                MessageBox.Show($"data sended all: \n\n{message}");
            }
            else
            {
                MessageBox.Show("null value.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            publisher?.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tasks = richTextBox1.Text;

            if (!string.IsNullOrWhiteSpace(tasks) && publisher != null)
            {
                string message = $"{tasks}";
                message += $"Tasks:{tasks}";
                channelselector(message);
                
            }
            else
            {
                MessageBox.Show("task is null");
            }
        }
        public void channelselector(string message)
        {
            string selectedUser = comboBox2.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedUser) && publisher != null)
            {
                if (selectedUser == "All")
                {
                    publisher.SendMoreFrame("All").SendFrame(message);
                    MessageBox.Show($"sended all: \n\n{message}");
                }
                else
                {
                    publisher.SendMoreFrame(selectedUser).SendFrame(message);
                    MessageBox.Show($"data {selectedUser} to : \n\n{message}");
                    History.Items.Add(selectedUser+"=>"+message);
                }
            }
        }

        
    }
}
