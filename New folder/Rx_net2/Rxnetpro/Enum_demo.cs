using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rxnetpro
{
    static class Enum_demo
    {
        public static IObservable<T> ToObservable<T>(this IEnumerable<T> source)
        {

            return Observable.Create<T>(o =>
            {
                foreach (var item in source)
                {
                    o.OnNext(item);
                }
              //  var subject = new ReplaySubject<int>();
                
                    // subject.OnNext
                    //Incorrect disposal pattern
                    return Disposable.Empty;
                    //   Observable.Start(() => Console.WriteLine(source));
                    // (() => Console.WriteLine(source));
                    //    Observable.SubscribeOn(V=>Console.WriteLine(V));
                });

            
            
        }
        static void Main(string[] args)
        {
            int[] a = { 12, 3, 4, 4, 5, 5 };
            ToObservable<int>(a).Subscribe(x=>Console.WriteLine(x));
        }
    }
}
