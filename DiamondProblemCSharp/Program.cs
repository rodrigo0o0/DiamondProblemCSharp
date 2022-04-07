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
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My Letter");
            Console.WriteLine(p.Print());

            Scanner s = new Scanner() { SerialNumber = 1070};
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());


            Console.ReadKey();
            
        }
    }
}
