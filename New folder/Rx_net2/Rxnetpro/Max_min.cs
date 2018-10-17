using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rxnetpro
{
    class Max_min
    {
        static void Main(string[] args)
        {
            var numbers = new Subject<int>();
            numbers.Dump("numbers");
            numbers.Min().Dump("Min");
            numbers.Max().Dump("Max");
            numbers.Average().Dump("Average");
            numbers.OnNext(1);
            numbers.OnNext(2);
            numbers.OnNext(3);
            numbers.OnCompleted();

            //first
            Console.WriteLine("first");
            var interval = Observable.Interval(TimeSpan.FromSeconds(3));
            //Will block for 3s before returning
            Console.WriteLine(interval.First());
        }
    }
}
