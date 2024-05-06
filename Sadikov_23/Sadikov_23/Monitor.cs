using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadikov_23
{
    internal class Monitor
    {
        public void HardwareOff(Object? sourceHardware, EventArgs e)
        {
            if (e is LowChargeEventArgs)
            {
                var lowCharge = (LowChargeEventArgs)e;
                Console.WriteLine(lowCharge.Message);
                if (sourceHardware is Hardware)
                {
                    var hardware = (Hardware)sourceHardware;
                    hardware.OffPower();
                }
            }
        }
    }
}
