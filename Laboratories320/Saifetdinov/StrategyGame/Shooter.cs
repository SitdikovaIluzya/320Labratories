using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Saifetdinov.StrategyGame
{
    class Shooter : Unit
    {
        public int RangeOfFire { get; set; }
        public int RateOfFire { get; set; }

        public void GoIntoMelee()
        {
            Console.WriteLine("I'm going into melee");
        }

        public void SettingUpWeapons()
        {
            Console.WriteLine("Charge it! Aim! Fire!");
        }


    }
}
