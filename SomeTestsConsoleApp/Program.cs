using System;

namespace SomeTestsConsoleApp
{
    sealed class Program
    {
        static Program()
        {
            Console.WriteLine("Static ctor");
        }

        static void SayHi()
        {
            Console.WriteLine("Hi");
        }
        
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
