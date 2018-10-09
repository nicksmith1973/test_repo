using System;
using System.Threading;

namespace GitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true) { Thread.Sleep(1000); }
        }
    }
}
