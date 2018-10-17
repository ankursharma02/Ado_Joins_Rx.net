using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;

namespace Rxnetpro
{
    class Task_demo
    {
        static void Main(string[] args)
        {
            var t = Task.Factory.StartNew(() => "Test");
            var source = t.ToObservable();
            source.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("completed"));
            Console.ReadLine();
        }
    }
}
