using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SomeTestsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            while (true)
            {
                Console.WriteLine("Введите адрес электронной почты");
                string email = Console.ReadLine();

                if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Email подтвержден");
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный email");
                }
            }
            Console.ReadKey();
        }
    }
}
