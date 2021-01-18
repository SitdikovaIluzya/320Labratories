using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Healer : Unit
    {
        public int HealingSpeed { get; set; }
        public int PercentageOfAllysSkillGain { get; set; }
        public int TimeToStunEnemies { get; set; }

        public void Healing()
        {
            Console.WriteLine("Running to treat");
        }
    }
}
