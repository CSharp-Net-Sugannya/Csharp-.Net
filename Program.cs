using System;
using System.Threading;

namespace ThreadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);
            t.Start();
            WriteX();
            void WriteX()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("x");
                }
            }
        }
       
        public static void WriteY()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Y");
            }
        }
    }
}
