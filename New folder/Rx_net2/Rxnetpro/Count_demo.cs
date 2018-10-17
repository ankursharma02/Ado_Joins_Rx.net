using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rxnetpro
{
    class Count_demo
    {
        static void Main(string[] args)
        {
            var numbers = Observable.Range(0, 3);
            numbers.Dump("numbers");
            numbers.Count().Dump("count");

            Console.ReadLine();
        }
    }
}
