using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5_1.ThreadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyThreadClass threadClass = new MyThreadClass("Day la tieu trinh thu 1...");
            Thread thread1 = new Thread(threadClass.Run);
            thread1.Start();

            MyThreadClass threadClass1 = new MyThreadClass("Day la tieu trinh thu 2...");
            Thread thread2 = new Thread(threadClass1.Run);
            thread2.Start();

            Console.ReadKey();
        }
    }
}
