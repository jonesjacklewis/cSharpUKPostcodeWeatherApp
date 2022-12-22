using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace cSharpWeatherApp
{
    public partial class formDetails : Form
    {

        private string postcode = "";
        private double[] latLong = {0,0};
        private HttpMethods http = new HttpMethods();
        private string tempFile = "";
        private const string CELSIUS_SYMBOL = "°C";
        private const string FAHRENHEIT_SYMBOL = "°F";
        private const string KELVIN_SYMBOL = "K";


        public formDetails(String postCode)
        {
            InitializeComponent();

            // https://stackoverflow.com/questions/5962595/how-do-you-resize-a-form-to-fit-its-content-automatically
            this.MinimumSize = new Size(this.Width, this.Height);

            // no larger than screen size
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.postcode = postCode;
            try
            {
                string url = $"http://api.getthedata.com/postcode/{this.postcode.Replace(" ", "%20")}";


                string content = http.GetString(url);
                JObject latLongJson = JObject.Parse(content);
                JToken data = latLongJson.GetValue("data");

                double latitude = double.Parse(data["latitude"].ToString());
                double longitude = double.Parse(data["longitude"].ToString());

                this.latLong[0] = latitude;
                this.latLong[1] = longitude;
            }
            catch(NullReferenceException exception)
            {
                this.postcode = "SW1A 2AA";
                string url = $"https://api.promaptools.com/service/uk/postcode-lat-lng/get/?postcode={"SW1A 2AA".Replace(" ", "%20")}&key=17o8dysaCDrgv1c";


                string content = http.GetString(url);
                JObject latLongJson = JObject.Parse(content);

                double latitude = double.Parse(latLongJson.SelectToken("output[0].latitude").ToString());
                double longitude = double.Parse(latLongJson.SelectToken("output[0].longitude").ToString());

                this.latLong[0] = latitude;
                this.latLong[1] = longitude;
            }
           

        }

        private void formDetails_Load(object sender, EventArgs e)
        {

            lblLocation.Text = $"Weather at {this.postcode}";

            double latitude = this.latLong[0];
            double longitude = this.latLong[1];

            string url = $"https://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&appid=1b94b4150df9cfc3e0eb1f3b9947e183";

            string content = http.GetString(url);
            JObject weatherJson = JObject.Parse(content);

            string weatherDescription = weatherJson.SelectToken("weather[0].description").ToString();
            string weatherIcon = weatherJson.SelectToken("weather[0].icon").ToString();

            double kelvinTemp = double.Parse(weatherJson.SelectToken("main.temp").ToString());
            double humidity = double.Parse(weatherJson.SelectToken("main.humidity").ToString());

            double windSpeedMS = double.Parse(weatherJson.SelectToken("wind.speed").ToString());

            int celsiusTemp = (int)Math.Floor(kelvinTemp - 273.15);
            double windSpeedMPH = Math.Round(windSpeedMS * 2.237, 2);


            lblTempValue.Text = $"{celsiusTemp}";
            lblTempUnit.Text = CELSIUS_SYMBOL;

            lblWeatherDesc.Text = weatherDescription;

            lblHumidityValue.Text = $"{humidity}%";
            lblWindValue.Text = $"{windSpeedMPH} miles per hour";

            this.tempFile = Path.ChangeExtension(Path.GetTempFileName(), "png");
            byte[] imageData = http.GetImage($"http://openweathermap.org/img/wn/{weatherIcon}@2x.png");

            File.WriteAllBytes(this.tempFile, imageData);

            Image weatherIconImage = Image.FromFile(this.tempFile);

            pbWeatherIcon.Width = (int)1.1 * weatherIconImage.Width;
            pbWeatherIcon.Height = (int)1.1 * weatherIconImage.Height;

            pbWeatherIcon.Image = weatherIconImage;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
 
            pbWeatherIcon.Image.Dispose();
            formLocation formLocation = new formLocation(this.tempFile);
            this.Hide();
            formLocation.Closed += (s, args) => this.Close();
            formLocation.Show();

        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            if(lblTempUnit.Text == CELSIUS_SYMBOL)
            {
                return;
            }

            double currentTemp = double.Parse(lblTempValue.Text);
            double tempC;

            if(lblTempUnit.Text == FAHRENHEIT_SYMBOL)
            {
                tempC = (currentTemp - 32) * (5.0 / 9.0);
            }
            else // kelvin
            {
                tempC = currentTemp - 273.15;
            }

            lblTempValue.Text = tempC.ToString();
            lblTempUnit.Text = CELSIUS_SYMBOL;
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            if(lblTempUnit.Text == FAHRENHEIT_SYMBOL)
            {
                return;
            }

            double currentTemp = double.Parse(lblTempValue.Text);
            double tempF;

            if(lblTempUnit.Text == CELSIUS_SYMBOL)
            {
                tempF = (currentTemp * (9.0 / 5.0)) + 32;
            }
            else // kelvin
            {
                tempF = ((currentTemp - 273.15) * (9.0 / 5.0)) + 32;
            }

            lblTempValue.Text = tempF.ToString();
            lblTempUnit.Text = FAHRENHEIT_SYMBOL;

        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            if(lblTempUnit.Text == KELVIN_SYMBOL)
            {
                return;
            }

            double currentTemp = double.Parse(lblTempValue.Text);
            double tempK;

            if (lblTempUnit.Text == CELSIUS_SYMBOL)
            {
                tempK = currentTemp + 273.15;
            }
            else // fahrenheit
            {
                tempK = ((currentTemp - 32) * (5.0 / 9.0)) + 273.15;
            }

            lblTempValue.Text = tempK.ToString();
            lblTempUnit.Text = KELVIN_SYMBOL;
        }
    }
}
