using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant : IObserver
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        public bool winStatus;
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        public Contestant(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.registrationNumber = registrationNumber;
            winStatus = false;
        }

        public void Notify(IObserver observer, IObserver winner)
        {
            if (winStatus)
            {
                Console.WriteLine($"Congratulations {winner.FirstName} on winning the sweepstakes! We hope to see you play again!");
            }
            else
            {
                Console.WriteLine($"Thank you {observer.FirstName} for playing in the sweepstakes! {winner.FirstName} won the sweepstakes.. but we hope to see you play again!");
            }
            
        }

        public string ContestantInfo(Contestant contestant)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(firstName);
            sb.Append(", ");
            sb.Append(lastName);
            sb.Append(", ");
            sb.Append(emailAddress);
            sb.Append(", ");
            sb.Append(registrationNumber.ToString());
            return sb.ToString();
        }
    }
}
