using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm marketingFirm = new MarketingFirm(SweepstakesManagerFactory.CreateSweepstakesManager(UserInterface.DecideManagerType()));
            marketingFirm.CreateSweepstake();
            SweepStakes sweep = marketingFirm._manager.GetSweepstakes();
            sweep.PrintContestant(sweep.PickWinner());
            
        }
    }
}
