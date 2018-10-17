using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rxnetpro
{
    class Skip_take
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skip ");
            Observable.Range(0, 10)
            .Skip(3)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));

            Console.WriteLine("Take");
            Observable.Range(0, 10)
            .Take(3)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));

            
        }
    }
}
