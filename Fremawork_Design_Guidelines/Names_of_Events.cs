using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fremawork_Design_Guidelines
{
    internal class Names_of_Events
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        private float currentTemperature;

        public float CurrentTemperature
        {
            get { return currentTemperature; }
            set
            {
                if (currentTemperature != value)
                {
                    currentTemperature = value;

                    // Raise the TemperatureChanged event when the temperature changes
                    OnTemperatureChanged(new TemperatureChangedEventArgs(value));
                }
            }
        }

        // Method to raise the TemperatureChanged event
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }
    }

    public class TemperatureChangedEventArgs : EventArgs
    {
        public float NewTemperature { get; }

        public TemperatureChangedEventArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }
    }
}

