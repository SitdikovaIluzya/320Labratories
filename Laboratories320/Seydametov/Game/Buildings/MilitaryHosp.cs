using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    class MilitaryHosp : Heroes , IHealTeammate
    {
        public MilitaryHosp(string UnitName, int UnitHealth) : base(UnitName, UnitHealth)
        {
        }

        public void HealTeammate(Heroes teammate)
        {
            throw new NotImplementedException();
        }
    }
}
