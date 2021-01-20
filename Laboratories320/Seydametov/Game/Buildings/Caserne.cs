using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    class Caserne : Heroes, IAddStrength
    {
        public Caserne(string UnitName, int UnitHealth) : base(UnitName, UnitHealth)
        {
        }

        public void AddPower(IStrength teammate)
        {
            throw new NotImplementedException();
        }
    }
}
