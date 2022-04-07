﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblemCSharp.Devices
{
    internal class Printer : Device, IPrinter
    {
        public string Print()
        {
            return "Printer print ";
        }


        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Processing Printer " + document);
        }
    }
}
