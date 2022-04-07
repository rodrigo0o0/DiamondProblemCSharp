using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblemCSharp.Devices
{
    internal class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer Processing : " + document);
        }


        public string Print()
        {
            return "Printer print Result";
        }
    }
}
