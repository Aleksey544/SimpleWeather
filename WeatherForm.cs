//WinForms SimpleWeather, developed by Alexey Kuzub
using System;
using System.Net;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SimpleWeather
{
    public partial class WeatherForm : Form
    {
        public WeatherForm()
        {
            InitializeComponent();
        }

        private void ShowWeatherInfo()
        {
            //Establishing a connection with the site via API
            string GetFromUser = InputTextBox.Text.Trim();
            string URL = "http://api.openweathermap.org/data/2.5/weather?q=" + GetFromUser + "&units=metric&appid=b8644caf0826b86815ab5f062919284a&lang=ru";
            string response;
            
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse httpWebResponse;

            try
            {
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                    MessageBox.Show("Город не найден!", "Сервер вернул ошибку 404");
                else if (ex.Status == WebExceptionStatus.NameResolutionFailure)
                    MessageBox.Show("Интернет соединение отсутствует!", "Программе не удалось подключиться к серверу");

                return;
            }

            using (StreamReader reader = new StreamReader(httpWebResponse.GetResponseStream()))
                response = reader.ReadToEnd();

            //Deserializating site's json response and output deserealized data to the user interface
            WeatherJsonReader Menu = JsonConvert.DeserializeObject<WeatherJsonReader>(response);

            CurrentCityLabel.Text = "Текущий город:   " + Menu.CityName;
            TemperatureLabel.Text = "Температура:   " + Math.Round(Menu.Main.temperature) + "°C";
            FellsTemperatureLabel.Text = "Ощущается:   " + Math.Round(Menu.Main.FellsTemperature) + "°C";
            MinTemperatureLabel.Text = "Минимально:   " + Math.Round(Menu.Main.MinTemperature) + "°C";
            MaxTemperatureLabel.Text = "Максимально:   " + Math.Round(Menu.Main.MaxTemperature) + "°C";
            PressureLabel.Text = "Давление:   " + Math.Round(Menu.Main.Pressure * 0.75) + "  мм рт ст";
            HumidityLabel.Text = "Влажность:   " + Menu.Main.Humidity + " %";
            WeatherConditionsLabel.Text = "Условия:   " + Menu.Conditions[0].WeatherConditions;
            CloudyLabel.Text = "Облачность:   " + Menu.Clouds.Cloudy + " %";
            SpeedWindLabel.Text = "Скорость ветра:   " + Math.Round(Menu.Wind.SpeedWind) + "  м/с";
            VisibilityLabel.Text = "Видимость:   " + Menu.Visibility + "  м";

            //Output to the user interface of weather conditions in the photos form
            try
            {
                switch (Menu.Conditions[0].IconConditions)
                {
                    case "01d":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\ClearSun.png");
                        break;
                    case "01n":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\ClearMoon.png");
                        break;
                    case "02d": case "03d":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\PartlyCloudySun.png");
                        break;
                    case "02n": case "03n":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\PartlyCloudyMoon.png");
                        break;
                    case "04d": case "04n":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\MainlyCloudy.png");
                        break;
                    case "09d": case "09n":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\ShowerRain.png");
                        break;
                    case "10d":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\RainSun.png");
                        break;
                    case "10n":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\RainMoon.png");
                        break;
                    case "11d":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\ThunderstormSun.png");
                        break;
                    case "11n":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\ThunderstormMoon.png"); 
                        break;
                    case "13d":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\SnowSun.png");
                        break;
                    case "13n":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\SnowMoon.png");
                        break;
                    case "50d" : case "50n":
                        WeatherShowPictureBox.Image = new Bitmap(@"..\..\resources\Mist.png");
                        break;
                    default:
                        WeatherShowPictureBox.Image = null;
                    break;
                }
            }
            catch (ArgumentException)
            {
                WeatherShowPictureBox.Image = null;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ShowWeatherInfo();
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                ShowWeatherInfo();
        }
    }
}
