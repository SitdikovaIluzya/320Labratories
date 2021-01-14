using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Dyubanov.StrategyGame
{
    class Hospital : Unit , IHealTeammate
    {
        public Hospital(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth, UnitProtection)
        {
        }

        public void HealTeammate(Unit teammate)
        {
            teammate.Health = teammate.Health + 10;
            throw new NotImplementedException();
        }
    }
}
