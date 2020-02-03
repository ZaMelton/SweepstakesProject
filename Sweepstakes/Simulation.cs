using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public MarketingFirm marketingFirm;
        public int numberOfSweepstakes;

        public void RunSimulation()
        {
            marketingFirm = CreateMarketingFirmWithManager();
            numberOfSweepstakes = UserInterface.ChooseHowManySweepstakesToCreate();

            for(int i = 0; i < numberOfSweepstakes; i++)
            {
                marketingFirm.CreateSweepstake();
            }

            for(int i = 0; i < numberOfSweepstakes; i++)
            {
                NotifyContestantsResults();
            }
        }

        public MarketingFirm CreateMarketingFirmWithManager()
        {
            MarketingFirm marketingFirm = new MarketingFirm(SweepstakesManagerFactory.CreateSweepstakesManager(UserInterface.DecideManagerType()));
            return marketingFirm;
        }

        public void NotifyContestantsResults()
        {
            SweepStakes sweep = marketingFirm._manager.GetSweepstakes();
            Contestant winner = sweep.PickWinner();
            winner.winStatus = true;

            bool winnerPrinted = false;
            foreach (KeyValuePair<int, Contestant> contestant in sweep.contestants)
            {
                if (contestant.Value.winStatus && !winnerPrinted)
                {
                    winner.Notify(contestant.Value, winner);
                    winnerPrinted = true;
                }
                else
                {
                    contestant.Value.Notify(contestant.Value, winner);
                }
            }
        }
    }
}
