using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = manager;
        }

        public void CreateSweepstake()
        {
            
        }
    }
}
