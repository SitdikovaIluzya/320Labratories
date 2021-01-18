using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class PotionsMaster : Worker, ICookingPotions
    {
        public int NumberPotions { get; set; }

        public void CookingPotions()
        {
            Console.WriteLine("I'm starting to brew potions");
        }
    }
}
