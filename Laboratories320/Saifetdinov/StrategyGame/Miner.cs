using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Miner : Worker
    {
        public int CapasityGold { get; set; }

        public void GoldMining()
        {
            Console.WriteLine("I'm going to mine gold");
        }
    }
}
