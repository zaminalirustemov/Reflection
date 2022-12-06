using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Student
    {
        private int _counter { get; set; }
        public Student()
        {
            _counter++;
            this.Id = _counter;
        }
        public int Id 
        {
            get=>_counter;
            set=> _counter = value;
        }
        public string Name { get; set; }
        public string Surname;

        public void ShowInfo()
        {
            Console.WriteLine($"{Id} {Name} {Surname}");
        }
    }
}
