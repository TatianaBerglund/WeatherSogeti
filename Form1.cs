using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApiKontorsApp
{
    public partial class Form1 : Form
    {
        const string APPID = "16cf11f6988d87a6495c88777633d9ea";
        string cityName = "Gothenburg";
        public Form1()
        {
            InitializeComponent();
            getWeather();
            getForecast();

        }

        void getWeather()

        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", cityName, APPID);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                WeatherInfo.Root outPut = result;

                lbl_cityName.Text = string.Format("{0}", outPut.name);
                lbl_country.Text = string.Format("{0}", outPut.sys.country);
                lbl_Temp.Text = string.Format("{0} \u00B0", outPut.main.temp-273,15);

                lbl_temperatura.Text = string.Format("{0}", outPut.wind.speed);




            }
        }
        void getForecast()

        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&appid={1}", cityName, APPID);
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<WeatherForcast>(json);
                
                WeatherForcast forcast = Object;


                lbl2_tempelatura.Text = string.Format("{0}", forcast.list[1].temp);

                //lbl2_tempelatura.Text = string.Format("{0}", Object.list.);
                //lbl_country.Text = string.Format("{0}", Object.);
                //lbl_Temp.Text = string.Format("{0} \u00B0", outPut.main.temp - 273, 15);

                //lbl_temperatura.Text = string.Format("{0}", outPut.wind.speed);

                                          
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_Forcast_Click(object sender, EventArgs e)
        {

        }

        private void lbl_wind_Click(object sender, EventArgs e)
        {

        }

        private void lbl_description_Click(object sender, EventArgs e)
        {

        }

        private void lbl_speed_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_pressure_Click(object sender, EventArgs e)
        {

        }

        private void lbl_humidity_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tempelatura_Click(object sender, EventArgs e)
        {

        }
    }
}
