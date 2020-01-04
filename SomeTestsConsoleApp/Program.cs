using System;
using System.IO;
using System.Text.Json;

namespace SomeTestsConsoleApp
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic x = 3; // здесь x - целочисленное int
            Console.WriteLine(x);

            x = "Привет мир"; // x - строка
            Console.WriteLine(x);

            x = new Person() { Name = "Tom", Age = 23 }; // x - объект Person
            Console.WriteLine(x);

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
