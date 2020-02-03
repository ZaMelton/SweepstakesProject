using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

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
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                emailAddress = value;
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
                EmailWinner(winner);
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

        public void EmailWinner(IObserver winner)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Marketing Firm", "donotrespond@gmail.com"));
            message.To.Add(new MailboxAddress($"{winner.FirstName}", $"{winner.EmailAddress}"));
            message.Subject = "Congratulations!";
            message.Body = new TextPart("plain")
            {
                Text = $"{winner.FirstName}, congrats on winning the sweepstakes! Enjoy your prize and we hope to see you play again!"
            };
            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.gmail.com", 587, false);

                //This is where to enter the user name and password of the senders email
                client.Authenticate("devcodetest7", "SuperChallengingPassword!");

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
