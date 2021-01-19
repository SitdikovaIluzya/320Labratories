using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    public class Citadel : Unit, IHealUnit
    {
        public Citadel(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        {
        }

        public void HealUnit(Unit unit)
        {
            unit.Health += 50;
            this.Health += 50;
        }
    }
}
