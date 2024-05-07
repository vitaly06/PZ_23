using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadikov_23
{
    internal class Hardware
    {
        public int Id { get; set; }
        public int Charge {  get; set; }
        public int Critical { get; set; } = 20;
        private bool _work = true;

        public Hardware(int id) => Id = id;
        public void OnPower()
        {
            if (this._work != false)
            {
                Charge = 100;
                for (int i = 0; i < 5; i++)
                {
                    if (Charge <= 20)
                    {
                        OnCriticalChargeLevelEvent();
                    }
                    else{
                        Console.WriteLine($"Устройство {this.Id} - {Charge -= 20}%");
                    }
                }
            }
        }

        public void OffPower()
        {
            _work = false;
            Console.WriteLine($"Критический уровень заряда. Устройство {this.Id} выключено");
        }

        public event EventHandler? CritChargeLevelEvent;
        public void OnCriticalChargeLevelEvent()
        {
            LowChargeEventArgs e = new LowChargeEventArgs($"Критический уровень заряда({Critical}%)");
            CritChargeLevelEvent?.Invoke( this, e ); 
        }
    }
}
