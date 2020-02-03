using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface IObserver
    {
        string FirstName { get; set; }
        string EmailAddress { get; set; }

        void Notify(IObserver observer, IObserver winner);
    }
}
