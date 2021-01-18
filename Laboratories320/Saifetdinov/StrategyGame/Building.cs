using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Building : BasicInformation, IWaitingBuilder, IBuildingDestroyed
    {
        public int AreaCastle { get; set; }

        public void BuildinDestroyed()
        {
            Console.WriteLine("The building was broken down");
        }

        public void WaitingBuilder()
        {
            Console.WriteLine("Builder's expectation");
        }
    }
}
