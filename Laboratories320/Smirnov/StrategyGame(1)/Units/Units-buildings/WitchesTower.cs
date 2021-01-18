using System;
using System.Collections.Generic;
using System.Text;
using Laboratories320.Smirnov.StrategyGame_1_.Interfaces;

namespace Laboratories320.Smirnov.StrategyGame_1_.Units.Units_buildings
{
    class WitchesTower : Unit, IDestroy, IDefend
    {
        public WitchesTower(string name, int health) : base(name, health)
        {

        }
        public void Defend(Unit unit)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

    }
}
