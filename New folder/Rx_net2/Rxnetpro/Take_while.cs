using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rxnetpro
{
    class Take_while
    {
        static void Main(string[] args)
        {
            var subject = new Subject<int>();
            subject
            .TakeWhile(i => i < 4)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            subject.OnNext(1);
            subject.OnNext(3);
            subject.OnNext(3);
            subject.OnNext(2);
            subject.OnNext(2);
            subject.OnNext(5);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnCompleted();
        }

    }
}
