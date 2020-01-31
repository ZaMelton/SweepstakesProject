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

        public static string DecideSweepstakesName()
        {
            Console.WriteLine("What will this Sweepstakes be called?");
            string choice = Console.ReadLine();
            return choice;
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

        public static string ContestantFirstName()
        {
            Console.WriteLine("What is the contestants first name?");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string ContestantLastName()
        {
            Console.WriteLine("What is the contestants last name?");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string ContestantEmail()
        {
            Console.WriteLine("What is the contestants Email?");
            string email = Console.ReadLine();
            return email;
        }
        public static int ContestantRegistrationNumber()
        {
            int registrationNumber;
            Console.WriteLine("What is the contestants registration number?");
            try
            {
                registrationNumber = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return ContestantRegistrationNumber();
            }
            
            return registrationNumber;
        }

        public static int ChooseHowManyContestantsToRegister()
        {
            int numberOfContestants;
            Console.WriteLine("How many contestants will you be adding?");
            try
            {
                numberOfContestants = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return ContestantRegistrationNumber();
            }

            return numberOfContestants;
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

    }
}
