using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    class ForgBuild : Unit, IRepairProtection
    {
        public ForgBuild(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        {
        }
        public void RepairProtection(Unit unit)
        {
            unit.Protection = unit.Protection + 10;
            throw new NotImplementedException();
        }
    }
}
