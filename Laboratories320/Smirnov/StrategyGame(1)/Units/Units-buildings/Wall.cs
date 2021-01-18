using System;
using System.Collections.Generic;
using System.Text;
using Laboratories320.Smirnov.StrategyGame_1_.Interfaces;

namespace Laboratories320.Smirnov.StrategyGame_1_.Units.Units_buildings
{
    class Wall : Unit, IDestroy
    {
        public Wall(string name, int health) : base(name, health)
        {

        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
