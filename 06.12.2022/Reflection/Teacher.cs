using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Teacher
    {
        string _name { get; set; }
        public string Name 
        {
            get => _name;
            set=> _name = value;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Name}");
        }
    }
}
