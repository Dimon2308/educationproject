using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Bus:ICar
    {
        public string Color { get; }
        public string Size { get; }
        public Bus(string saiz, string col)
        {
            Size = saiz;
            Color = col;
        }
        public bool GoToGarage()
        {
            return false;
        }
    }
}
