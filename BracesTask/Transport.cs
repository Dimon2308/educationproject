using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracesTask
{
    class Transport
    {
        public int Weight { get; set; }
        public string Model { get; set; }
        public  void Move()
        {
            Console.WriteLine(Model + "is moving");
        }
    }
}
