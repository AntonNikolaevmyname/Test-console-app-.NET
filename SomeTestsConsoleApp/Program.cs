using System;

namespace SomeTestsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "haHAA";

            Int32 i1 = 1;
            Int32 i2;
            i2 = i1;
            i1 = 3;
            Console.WriteLine($"{GC.GetTotalMemory(false)}");
            Console.Beep();
            
            Console.ReadKey();
        }
    }
}
