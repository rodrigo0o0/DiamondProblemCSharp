using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblemCSharp.Devices
{
    internal class Scanner : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner Processing : "+ document);
        }

        public string Scan()
        {
            return "Scanner scan Result";
        }
    }
}
