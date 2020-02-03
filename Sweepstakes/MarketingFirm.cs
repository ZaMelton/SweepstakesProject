using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = manager;
        }

        public void CreateSweepstake()
        {
            SweepStakes sweepStakes = new SweepStakes(UserInterface.DecideSweepstakesName());

            //Register contestants
            int numberOfContestants = UserInterface.ChooseHowManyContestantsToRegister();
            for(int i = 0; i < numberOfContestants; i++)
            {
                UserInterface.Display($"Please enter contestant {i + 1}'s info: ");
                sweepStakes.RegisterContestant(new Contestant(UserInterface.ContestantFirstName(), UserInterface.ContestantLastName(), UserInterface.ContestantEmail(), UserInterface.ContestantRegistrationNumber()));
                UserInterface.ClearConsole();
            }

            _manager.InsertSweepstakes(sweepStakes);
        }
    }
}
