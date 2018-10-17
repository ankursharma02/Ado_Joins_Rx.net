using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rxnetpro
{
    class Program
    {
        static void StartAction()
        {
            var start = Observable.Start(() =>
            {
                Console.WriteLine("Working away");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(10000);
                    Console.WriteLine("A");
                }
            });
            
            start.Subscribe(
            unit => Console.WriteLine("Unit published"),
            () => Console.WriteLine("Action completed"));
        }
        static void StartFunc()
        {
            var start = Observable.Start(() =>
            {
                Console.WriteLine("Working away");
                for (int i = 0; i < 10; i++)
                {
                   Thread.Sleep(1000);
                    Console.WriteLine("B");
                }
                return "Published value";
            });
            start.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("Action completed"));
        }
        static void Main(string[] args)
        {
            StartAction();
            StartFunc();
        }
    }
}
