using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void RunSimulation()
        {
            MarketingFirm marketingFirm = CreateMarketingFirmWithManager();
            int numberOfSweepstakes = UserInterface.ChooseHowManySweepstakesToCreate();

            for(int i = 0; i < numberOfSweepstakes; i++)
            {
                marketingFirm.CreateSweepstake();
            }

            for(int i = 0; i < numberOfSweepstakes; i++)
            {
                SweepStakes sweep = marketingFirm._manager.GetSweepstakes();
                UserInterface.Display($"{sweep.Name} winner: ");
                sweep.PrintContestant(sweep.PickWinner());
            }
        }

        public MarketingFirm CreateMarketingFirmWithManager()
        {
            MarketingFirm marketingFirm = new MarketingFirm(SweepstakesManagerFactory.CreateSweepstakesManager(UserInterface.DecideManagerType()));
            return marketingFirm;
        }
    }
}
