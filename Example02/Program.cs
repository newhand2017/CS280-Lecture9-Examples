using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WeatherStation station1 = new WeatherStation;
            station1.stationName = "陽明山";
            station1.dataTimer = 200; //ms

            WeatherStation station2 = new WeatherStation;
            station2.stationName = "玉山";
            station2.dataTimer = 1100; //ms

            station1.Show();    //顯示視窗
            station2.Show();

            Application.Run(new WeatherStation());
        }
    }
}