using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar auto = new Auto("small", "red");
            ICar bas = new Bus("big", "white");
            auto.GoToGarage();
            bas.GoToGarage();
            Console.WriteLine(auto.Size);
            Console.WriteLine(auto.Color);
        }
    }
}
