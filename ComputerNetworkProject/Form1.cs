using System;
using System.Net;
using System.Net.Mail;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ComputerNetworkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] turkishCities = {
        "Adana", "Adýyaman", "Afyonkarahisar", "Aðrý", "Amasya", "Ankara", "Antalya", "Artvin",
        "Aydýn", "Balýkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale",
        "Çankýrý", "Çorum", "Denizli", "Diyarbakýr", "Edirne", "Elazýð", "Erzincan", "Erzurum", "Eskiþehir",
        "Gaziantep", "Giresun", "Gümüþhane", "Hakkari", "Hatay", "Isparta", "Mersin", "Ýstanbul", "Ýzmir",
        "Kars", "Kastamonu", "Kayseri", "Kýrklareli", "Kýrþehir", "Kocaeli", "Konya", "Kütahya", "Malatya",
        "Manisa", "Kahramanmaraþ", "Mardin", "Muðla", "Muþ", "Nevþehir", "Niðde", "Ordu", "Rize", "Sakarya",
        "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdað", "Tokat", "Trabzon", "Tunceli", "Þanlýurfa", "Uþak",
        "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "Kýrýkkale", "Batman", "Þýrnak",
        "Bartýn", "Ardahan", "Iðdýr", "Yalova", "Karabük", "Kilis", "Osmaniye", "Düzce"
    };

            foreach (string city in turkishCities)
            {
                comboBox1.Items.Add(city);
            }

            comboBox1.SelectedIndex = 0; // Varsayýlan olarak ilk þehri seçin

            // Seçili þehir için hava durumunu yükleyin
            LoadWeatherDataAsync(comboBox1.SelectedItem.ToString());
        }


        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBox1.SelectedItem.ToString();
            await LoadWeatherDataAsync(selectedCity);
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
                        var weatherDesc = weatherState.Attribute("value").Value;
                        var hum = humidity.Attribute("value").Value;
                        var speed = windSpeed.Attribute("value").Value;
                        var cityId = cityName.Attribute("id").Value;
                        var cityNameValue = cityName.Attribute("name").Value;

                        label1.Text = $"{cityNameValue} sýcaklýk: {temp}°C" ;
                        label2.Text = $"{cityNameValue} durumu: {weatherDesc}";
                        label5.Text= $"Nem: {hum}%";
                        label6.Text= $" Rüzgar Hýzý: {speed} m/s";
                    }
                    else
                    {
                        label1.Text = "Hava durumu bilgisi alýnamadý.";
                        label2.Text = "Belirtilen þehir bulunamadý.";
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Hava durumu bilgisi alýnamadý.";
                label2.Text = "Hata: " + ex.Message;
            }
        }


        private void buttonSendEmail_Click(object sender, EventArgs e)
        {
            string emailAddress = textBox1.Text;
            if (!string.IsNullOrEmpty(emailAddress))
            {
                SendEmail(emailAddress);
            }
            else
            {
                MessageBox.Show("Lütfen bir e-posta adresi girin.");
            }
        }

        private void SendEmail(string emailAddress)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");

                mail.From = new MailAddress("canberat__@outlook.com");
                mail.To.Add(emailAddress);
                mail.Subject = "Hava Durumu Bilgisi";

                string weatherInfo = $"{comboBox1.SelectedItem} için güncel hava durumu:\n\n{label1.Text}\n{label2.Text}\n\n{label1.Text}\n{label6.Text}";
                mail.Body = weatherInfo;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("canberat__@outlook.com", "sifre");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("E-posta baþarýyla gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilemedi. Hata: " + ex.Message);
            }
        }

    }
}
