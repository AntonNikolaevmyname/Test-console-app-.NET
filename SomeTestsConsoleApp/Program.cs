using System;

namespace SheetsQuickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = null;
            o.GetHashCode();
            ABC abc = new ABC();
            abc.GetType();
            Console.ReadLine();
        }
    }

    interface IA
    {
        // В интерфейсе можно использовать статические поля.
        public static int ia = 0;
        // Экземплярные нельзя.
        //public int ib = 0;

        // Но МОЖНО свойства.
        public abstract int Ib { get; set; }

        public delegate void Proger();
        public abstract event Proger proger;
        public abstract void Method1();
        public virtual void Method2()
        {
            Console.Write("dfgdfg");
        }
    }
    public class AB : object
    {
        
        
    }
    public class ABC : AB
    {
        public ABC()
        {
            AB ab = new AB();
        }
    }
    abstract class AA : AB
    {
        // В абстрактном классе можно использовать статические поля.
        public static int ia = 0;
        // Экземплярные тоже.
        public int ib = 0;
        public abstract int Ib { get; set; }

        public delegate void Proger();
        public abstract event Proger proger;

        public virtual void Method()
        {
            Console.Write("dfgdfg");
        }
    }

    struct A: IA
    {
        // В структуре можно использовать статические поля.
        public static int ia = 0;
        // Но нельзя инициализировать поля экземпляра.
        public int ib;

        public int Ib { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public delegate void Proger();
        public event Proger proger;

        event IA.Proger IA.proger
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public void Method1()
        {
            throw new NotImplementedException();
        }
    }
}