using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Killer : Unit
    {
        public int TimeOfInvisibility { get; set; }

        public void ToKillFromAmbush()
        {
            Console.WriteLine("I see the goal, I go to the goal");
        }
    }
}
