using System;

namespace SomeTestsConsoleApp
{
    public static class Int32Extensions
    {
        public static void SayHiFromInt(this int i)
        {
            Console.WriteLine("Hi " + i);
        }
    }
    internal sealed class Program
    {        
        static void Main(string[] args)
        {
            int i = 0;
            i.SayHiFromInt();
            Console.ReadKey();
        }
    }
}
