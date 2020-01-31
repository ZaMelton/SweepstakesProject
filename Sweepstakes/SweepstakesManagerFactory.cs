using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesManagerFactory
    {
        public ISweepstakesManager CreateManager(string choice)
        {
            switch (choice)
            {
                case "queue":
                    return new SweepstakesQueueManager();
                case "stack":
                    return new SweepstakesStackManager();
            }
            return CreateManager(choice);
        }
    }
}
