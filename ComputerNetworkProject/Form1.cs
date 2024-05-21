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
        "Adana", "Ad�yaman", "Afyonkarahisar", "A�r�", "Amasya", "Ankara", "Antalya", "Artvin",
        "Ayd�n", "Bal�kesir", "Bilecik", "Bing�l", "Bitlis", "Bolu", "Burdur", "Bursa", "�anakkale",
        "�ank�r�", "�orum", "Denizli", "Diyarbak�r", "Edirne", "Elaz��", "Erzincan", "Erzurum", "Eski�ehir",
        "Gaziantep", "Giresun", "G�m��hane", "Hakkari", "Hatay", "Isparta", "Mersin", "�stanbul", "�zmir",
        "Kars", "Kastamonu", "Kayseri", "K�rklareli", "K�r�ehir", "Kocaeli", "Konya", "K�tahya", "Malatya",
        "Manisa", "Kahramanmara�", "Mardin", "Mu�la", "Mu�", "Nev�ehir", "Ni�de", "Ordu", "Rize", "Sakarya",
        "Samsun", "Siirt", "Sinop", "Sivas", "Tekirda�", "Tokat", "Trabzon", "Tunceli", "�anl�urfa", "U�ak",
        "Van", "Yozgat", "Zonguldak", "Aksaray", "Bayburt", "Karaman", "K�r�kkale", "Batman", "��rnak",
        "Bart�n", "Ardahan", "I�d�r", "Yalova", "Karab�k", "Kilis", "Osmaniye", "D�zce"
    };

            foreach (string city in turkishCities)
            {
                comboBox1.Items.Add(city);
            }

            comboBox1.SelectedIndex = 0; // Varsay�lan olarak ilk �ehri se�in

            // Se�ili �ehir i�in hava durumunu y�kleyin
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

                        label1.Text = $"{cityNameValue} s�cakl�k: {temp}�C" ;
                        label2.Text = $"{cityNameValue} durumu: {weatherDesc}";
                        label5.Text= $"Nem: {hum}%";
                        label6.Text= $" R�zgar H�z�: {speed} m/s";
                    }
                    else
                    {
                        label1.Text = "Hava durumu bilgisi al�namad�.";
                        label2.Text = "Belirtilen �ehir bulunamad�.";
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "Hava durumu bilgisi al�namad�.";
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
                MessageBox.Show("L�tfen bir e-posta adresi girin.");
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

                string weatherInfo = $"{comboBox1.SelectedItem} i�in g�ncel hava durumu:\n\n{label1.Text}\n{label2.Text}\n\n{label1.Text}\n{label6.Text}";
                mail.Body = weatherInfo;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("canberat__@outlook.com", "sifre");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("E-posta ba�ar�yla g�nderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta g�nderilemedi. Hata: " + ex.Message);
            }
        }

    }
}
