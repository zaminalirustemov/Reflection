using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWFruit
{
    internal abstract class FruitBase
    {
        public List<string> Vitamins=new List<string>();
        private static int _id;
        public FruitBase()
        {
            _id++;
            Id = _id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
