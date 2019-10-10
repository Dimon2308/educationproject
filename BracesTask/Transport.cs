using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracesTask
{
    class Transport
    {
        public int weight { get; set; }
        public string model { get; set; }
        public  void Move()
        {
            Console.WriteLine(model + "is moving");
        }
    }
}
