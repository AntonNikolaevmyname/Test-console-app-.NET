using System;

namespace SomeTestsConsoleApp
{
    public interface IA { public void Method(); }
    public interface IB { public void Method(); }
    public class A : IA, IB
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
    }
    internal sealed class Program
    {        
        static void Main(string[] args)
        {
            IA ia = new A();
            IB ib = new A();
            A a = new A();

            
            ia.Method();
            ib.Method();
            a.Method();

            Console.ReadKey();
        }
    }
}
