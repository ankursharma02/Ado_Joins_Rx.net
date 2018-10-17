using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adonet_Demo
{
    class Linq_demo1
    {
        static void Main(string[] args)
        {

        
        string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };

        //Get only short words
        var shortWords = from x in words where x.Length <= 5 select x;
	    
      //Print each word out
        foreach (var word in shortWords)
        {
             Console.WriteLine(word);
        }

        Console.ReadLine();
        }
    }
}
