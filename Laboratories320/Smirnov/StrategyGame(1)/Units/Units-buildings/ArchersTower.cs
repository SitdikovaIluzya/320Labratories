using Laboratories320.Smirnov.StrategyGame_1_.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Smirnov.StrategyGame_1_.Units.Units_buildings
{
    class ArchersTower : Unit, IDefend, IDestroy
    {
        public ArchersTower(string name, int health) : base(name, health)
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
