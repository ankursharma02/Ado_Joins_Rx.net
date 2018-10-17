using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rxnetpro
{
    class DefaultEmpty_demo
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("Subject completed"));
            var defaultIfEmpty = subject.DefaultIfEmpty();
            defaultIfEmpty.Subscribe(
            b => Console.WriteLine("defaultIfEmpty value: {0}", b),
            () => Console.WriteLine("defaultIfEmpty completed"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnCompleted();

            Console.WriteLine("Second part");

            var subject1 = new Subject<int>();
            subject.Subscribe(
            Console.WriteLine,
            () => Console.WriteLine("Subject completed"));
            var defaultIfEmpty1 = subject.DefaultIfEmpty();
            defaultIfEmpty1.Subscribe(
            b => Console.WriteLine("defaultIfEmpty value: {0}", b),
            () => Console.WriteLine("defaultIfEmpty completed"));
            var default42IfEmpty = subject1.DefaultIfEmpty(42);
            default42IfEmpty.Subscribe(
            b => Console.WriteLine("default42IfEmpty value: {0}", b),
            () => Console.WriteLine("default42IfEmpty completed"));
            subject1.OnCompleted();
        }
    }
}
