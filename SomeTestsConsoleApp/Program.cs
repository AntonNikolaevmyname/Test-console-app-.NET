using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using print = System.Console;

namespace SomeTestsConsoleApp
{
    class Program
    {
        static dynamic a = new Int32();
        
        static object c = new Int32();
        static void Main(string[] args)
        {
            MethodInfo type = c.GetType().GetMethod("GetType");
            a = "aaa";
            //var b = new Int32();
            print.WriteLine(type.ToString());
            Console.ReadKey();
        }
    }
}
