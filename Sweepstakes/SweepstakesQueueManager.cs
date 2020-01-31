using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<SweepStakes> queue;

        public SweepstakesQueueManager()
        {
            queue = new Queue<SweepStakes>();
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public SweepStakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
