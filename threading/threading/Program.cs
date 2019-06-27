using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threading
{
    class Program
    {
        static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread {0}", i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Last name is Bubblu");
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));

            //IsBackground se thread application ka hissa nhi rehta
            t.IsBackground = false;
            t.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread {0}", i);
                Thread.Sleep(0);
            }

            //Console.WriteLine("First name is Arslan");
            t.Join();

            Console.ReadKey();
        }
    }
}
