using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Musin.StrategyGame
{
    class Healer : WarUnit, IHeal
    {
        public override int Health { get; set; } = 300;
        public void Heal(Unit unit)
        {
            throw new NotImplementedException();
        }
    }
}
