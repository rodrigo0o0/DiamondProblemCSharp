using DiamondProblemCSharp.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondProblemCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComboDevice p = new ComboDevice() { SerialNumber = 1080 };
            p.ProcessDoc("My Letter");
            Console.WriteLine(p.Print());
            Console.WriteLine(p.Scan());




            Console.ReadKey();
            
        }
    }
}
