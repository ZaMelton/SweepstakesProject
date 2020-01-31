using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class SweepstakesManagerFactory
    {
        public static ISweepstakesManager CreateSweepstakesManager(string choice)
        {
            switch (choice)
            {
                case "queue":
                    return new SweepstakesQueueManager();
                case "stack":
                    return new SweepstakesStackManager();
            }
            return CreateSweepstakesManager(choice);
        }
    }
}
