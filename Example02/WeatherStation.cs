using Example01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public partial class WeatherStation : Form, IOberverable, IObserver
    {
        //-------------------------------------------------
        private WeatherData data;

        private List<IObserver> observers;

        public string stationName { get; set; }

        //-------------------------------------------------

        public WeatherStation()
        {
            InitializeComponent();

            data = WeatherData.Generate();
            observers = new List<IObserver>();
            observers.Add(this);

            UpdateView(this, data);
        }

        //-------------------------------------------------
        //右鍵生成
        void IOberverable.Register(IObserver o)
        {
            observers.Add(o);
        }

        void IOberverable.RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        void IOberverable.Notify()
        {
            o.UpdateView(this, this.data);
        }

        public void UpdateView(object sender, EventArgs e)
        {
            this.tempTextBox.Text = this.data.Temp.ToString();
            this.humidtyTextBox.Text = this.data.Humidty.ToString();
            this.pressureTextBox.Text = this.data.Pressure.ToString();
        }

        //-------------------------------------------------
        private void OnMessurementsChanged(object sender, EventArgs e)
        {
            WeatherData other = e as WeatherData;
            if (!this.data.Equals(other))
            {
                this.data = other;
                Notify();
            }
        }

        //Double click Timer
        private void dataTimer_Tick(object sender, EventArgs e)
        {
            WeatherData other = WeatherData.Generate();
            OnMessurementsChanged(this, other);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.dataTimer.Enabled = this.dataTimer.Enabled;

            this.startButton.Text = this.dataTimer.Enabled ? "Pause" : "Start";
        }

        //-------------------------------------------------
    }
}