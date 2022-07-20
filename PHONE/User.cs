﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHONE
{
    internal class User
    {
        public Contract Contract { get; set; }
        public Port Port { get; set; }
        public Terminal Terminal { get; set; }

        public User(Contract contract, Port port, Terminal terminal)
        {
            Contract = contract;
            Port = port;
            Terminal = terminal;
        }

    }
}