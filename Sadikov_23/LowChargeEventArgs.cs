using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadikov_23
{
    internal class LowChargeEventArgs : EventArgs
    {
        public string Message { get; set; }
        public LowChargeEventArgs(string message) => Message = message;

        public override string ToString()
        {
            return Message;
        }
    }
}
