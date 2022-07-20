using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONE
{
    internal class PortEventARGS : EventArgs
    {
        public delegate void PortStateHandler(Port? sender, PortEventARGS? e);
        public string Message { get; private set; }
        public int AbonentNumber { get; private set; }
        public PortEventARGS(string message)
        {
            Message = message;
        }
       // public PortEventARGS(int abonentNumber) => AbonentNumber = abonentNumber;


    }
}
