using System;
using System.Collections.Generic;
using System.Linq;

namespace SomeTestsConsoleApp
{
    public interface IA { public void Method(); }
    public interface IB { public void Method(); }
    public class A : IA, IB, IDisposable
    {
        void IA.Method()
        {
            Console.WriteLine("Ia method");
        }

        void IB.Method()
        {
            Console.WriteLine("Ib method");
        }

        internal void Method()
        {
            Console.WriteLine("A method");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
        }
    }

    class Phone
    {
        public string Name { get; set; }
        public string Company { get; set; }
    }

    internal sealed class Program
    {        
        static void Main(string[] args)
        {
            string[] teams = { "авария", "Боруссия", "Реал Мадрид", 
                "Манчестер Сити", "ПСЖ", "Барселона" };

            var selectedTeams = from a in teams
                                where a.Length > 3
                                orderby a.Length descending
                                select a;

            int[] ints = { 1, 3, 5, 6, 7 };

            var max = from i in ints
                      where i == ints.Max()
                      select i;

            


            List<Phone> phones = new List<Phone>
            {
                new Phone {Name="Lumia 430", Company="Microsoft" },
                new Phone {Name="Mi 5", Company="Xiaomi" },
                new Phone {Name="LG G 3", Company="LG" },
                new Phone {Name="iPhone 5", Company="Apple" },
                new Phone {Name="Lumia 930", Company="Microsoft" },
                new Phone {Name="iPhone 6", Company="Apple" },
                new Phone {Name="Lumia 630", Company="Microsoft" },
                new Phone {Name="LG G 4", Company="LG" }
            };

            var phoneGroups = from phone in phones
                              group phone by phone.Company;

            foreach (IGrouping<string, Phone> g in phoneGroups)
            {
                Console.WriteLine(g.Key);
                foreach (var t in g)
                    Console.WriteLine(t.Name);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
