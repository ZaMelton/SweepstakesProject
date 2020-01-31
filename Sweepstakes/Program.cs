using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> things = new Dictionary<int, string>();

            things.Add(0, "dog");
            things.Add(1, "cat");
            things.Add(2, "foot");
            things.Add(3, "ear");


            Console.WriteLine(things[1]);
            Console.ReadLine();


        }
    }
}
