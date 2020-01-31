using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<SweepStakes> stack;

        public SweepstakesStackManager()
        {
            stack = new Stack<SweepStakes>();
        }

        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public SweepStakes GetSweepstakes()
        {
            return stack.Pop();
        }

    }
}
