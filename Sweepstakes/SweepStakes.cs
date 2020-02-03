using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepStakes
    {
        Dictionary<int, Contestant> contestants;
        string name;
        public string Name {get => name; set => name = value;}

        public SweepStakes(string name)
        {
            this.Name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
        }

        public Contestant PickWinner()
        {
            Random rand = new Random();
            int winner = rand.Next(contestants.Count);
            return contestants[winner];
        }

        public void PrintContestant(Contestant contestant)
        {
            UserInterface.Display(contestant.ContestantInfo(contestant)); 
        }
    }
}
