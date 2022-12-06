using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            Student student = new Student();
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (var item in assembly.GetTypes())
            {
                if (item == typeof(Student) )
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("**********************************");
                    Console.ResetColor();
                    Console.WriteLine("Type:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\t  {item.Name}");
                    Console.ResetColor();
                    Console.WriteLine("Properties:");
                    foreach (var item1 in item.GetProperties(/*BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic*/))
                    {
                        if (item1.Name == "Name")
                        {

                            item1.SetValue(student, "Zaminali");
                            Console.WriteLine(item1.GetValue(student));
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\t  {item1.Name}");
                        Console.ResetColor();
                    }
                    Console.WriteLine("Fields:");
                    foreach (var item1 in item.GetFields())
                    {
                       
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\t  {item1.Name}");
                        Console.ResetColor();
                    }
                    Console.WriteLine("Methods:");
                    foreach (var item1 in item.GetMethods())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\t  {item1.Name}");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}