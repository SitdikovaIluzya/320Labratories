using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    public abstract class Unit
    {
        public string Name;
        public int Health;
        public int Protection;

        public Unit(string UnitName, int UnitHealth, int UnitProtection)
        {
            Name = UnitName;
            Health = UnitHealth;
            Protection = UnitProtection;
        }
    }
}
