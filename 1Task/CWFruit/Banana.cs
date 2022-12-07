using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWFruit
{
    internal class Banana : FruitBase
    {
        public Banana(string name, string color, List<string> vitamins)
        {
            Name = name;
            Color = color;
            this.Vitamins = vitamins;
        }
    }
}
