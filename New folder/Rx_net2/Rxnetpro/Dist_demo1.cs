using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rxnetpro
{
    class Dist_demo1
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            var distinct = subject.DistinctUntilChanged();
            subject.Subscribe(
            i => Console.WriteLine("{0}", i),
            () => Console.WriteLine("subject.OnCompleted()"));
            distinct.Subscribe(
            i => Console.WriteLine("distinct.OnNext({0})", i),
            () => Console.WriteLine("distinct.OnCompleted()"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnNext(1);
            subject.OnNext(1);
            subject.OnNext(4);
            subject.OnNext(1);
            subject.OnNext(1); subject.OnNext(1); subject.OnNext(1); subject.OnNext(1);
            subject.OnNext(1);
            subject.OnCompleted();
        }
    }
}
