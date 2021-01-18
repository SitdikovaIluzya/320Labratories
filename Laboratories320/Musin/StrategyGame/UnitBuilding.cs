using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Musin.StrategyGame
{
    class UnitBuilding : Unit, IConstructable
    {
        public override int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void Construct()
        {
            throw new NotImplementedException();
        }
    }
}
