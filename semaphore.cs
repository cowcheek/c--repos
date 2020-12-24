using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadDemo
{
    class MyThread
    {
        
        private int sum=100;
        
        Semaphore sem1 = new Semaphore(1, 1);
        public int Sum { get => sum; }

        public void Summation1()
        {
            //mut.WaitOne();
            sem1.WaitOne();
            sum -= 20;//CS
            sem1.Release();
        
        }

        public void Summation2()
        {
            //mut.WaitOne();
            sem1.WaitOne();
            //CS
            {
                int temp = sum;
                Thread.Sleep(1000);
                temp += 40;
                sum = temp;
            }
            sem1.Release();
           
        }
     
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread demoThread = new MyThread();

            Thread thread1 = new Thread(demoThread.Summation1);
            Thread thread2 = new Thread(new ThreadStart(demoThread.Summation2));
            thread2.Priority = ThreadPriority.Highest;
            thread1.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine("Result:" + demoThread.Sum);
            Console.WriteLine("Main thread is exiting");
            Console.ReadLine();
        }
    }
}
