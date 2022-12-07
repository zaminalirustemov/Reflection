using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CWFruit
{
    internal class Fruit : IFruit
    {
        public List<FruitBase> Fruits = new List<FruitBase>();
        public void AddFruit(FruitBase value)
        {
            Fruits.Add(value);
        }

        public void ShowAllFruit()
        {
            foreach (var item in Fruits)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Color}");
            }
        }

        public void ShowFruit<T>(T item)
        {
            foreach (var item3 in Fruits)
            {
                if (item3.GetType() == typeof(T))
                {
                    Console.WriteLine(item3.Name);
                }
            }
        }
    }
}
