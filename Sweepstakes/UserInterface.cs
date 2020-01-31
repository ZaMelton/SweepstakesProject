using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void Display(string output)
        {
            Console.WriteLine(output);
        }

        public static string DecideManagerType()
        {
            Console.WriteLine("What type of Sweepstake manager would you like to use?\n1) Queue\n2) Stack");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    return "queue";
                case "2":
                    return "stack";
                default:
                    return DecideManagerType();
            }
        }
    }
}
