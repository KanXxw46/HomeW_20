using System;

namespace Hw20
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            Console.ReadLine();
        }

        private static void Test()
        {
            Dispos p = null;
            try
            {
                p = new Dispos();
            }
            finally
            {
                if (p != null)
                {
                    p.Dispose();
                }
            }
        }
    }
    public class Person : IDisposable
    {
        public string Name { get; set; }
        public void Dispose()
        {
            Console.Beep();
            Console.WriteLine("Disposed");
        }
    }
}
