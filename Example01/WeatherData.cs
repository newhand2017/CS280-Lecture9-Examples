using MyExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class WeatherData
    {
        //-------------------------------------------------

        public double Temp { get; set; }

        public double Humidty { get; set; }

        public double Pressure { get; set; }

        private static Random random;

        //-------------------------------------------------
        public WeatherData(double temp, double humidty, double pressure)
        {
            this.Temp = temp;
            this.Humidty = humidty;
            this.Pressure = pressure;
        }

        //-------------------------------------------------
        //
        public override bool Equals(object obj)
        {
            if (obj is WeatherData)
            {
                WeatherData other = obj as WeatherData;
                return (
                    this.Temp == other.Temp
                    && this.Humidty == other.Humidty
                    && this.Pressure == other.Pressure);
            }
            else
            {
                return false;
            }
        }

        //產生測試資料
        public static WeatherData Generate()
        {
            if (WeatherData.random != null)
            {
                random = new Random();
            }

            double temp = random.NextDouble(15.0, 26.0);
            double pressure = random.NextDouble(0.95, 1.0);
            double humidty = random.NextDouble(80, 100);

            return new WeatherData(temp, humidty, pressure);
        }

        //-------------------------------------------------
    }
}