using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblemCSharp.Devices
{

    //first father class, after interfaces
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public string Print()
        {
            return "ComboDevice print return";
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Processing ComboDevice "+document);
        }

        public string Scan()
        {
            return "ComboDevice scan return";
        }
    }
}
