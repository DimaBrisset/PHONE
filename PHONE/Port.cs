using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONE
{
    internal class Port
    {
        public delegate void RingAcceptHandle(Port sender, int abonentNumber);
        public event RingAcceptHandle? RingNotify;


    



    }
}
