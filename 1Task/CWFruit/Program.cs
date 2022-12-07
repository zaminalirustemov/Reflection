using System.Collections.Concurrent;

namespace CWFruit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FruitBase> list = new List<FruitBase>();
            Apple apple = new("Sirin alma","Qirmizi",new List<string> { "A","B"});
            Pie pie1 = new("Aci armud","Yasil",new List<string> { "C","D"});
            Pie pie2 = new("Entiqe armud","Xamilyon",new List<string> {"E", "C","D"});
            Banana banana = new("Turs banan","Sari",new List<string> { "E","B12"});

            Fruit fruit = new Fruit();
            fruit.AddFruit(apple);
            fruit.AddFruit(pie1);
            fruit.AddFruit(pie2);
            fruit.AddFruit(banana);


            fruit.ShowAllFruit();
            Console.WriteLine("********************");
            fruit.ShowFruit(pie1);
            Console.WriteLine("********************");
        }
    }
}