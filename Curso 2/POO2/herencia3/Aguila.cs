﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Aguila : AnimalDomestico, Flyable
    {
        public string volar()
        {
            return "vuela un montón";
        }
    }
}
