using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblemCSharp.Devices
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Processing Scanner " + document);
        }

        public string Scan()
        {
            return "Scanner scan return";
        }
    }
}
