using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    public abstract class Heroes
    {
        public string Name;
        public int Health;
        

        public Heroes(string UnitName, int UnitHealth)
        {
            Name = UnitName;
            Health = UnitHealth;
            
        }
    }
}
