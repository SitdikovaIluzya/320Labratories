using Laboratories320.Seydametov.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    public class Fortress : Heroes, ICityDefence
    {
        public Fortress(string UnitName, int UnitHealth) : base(UnitName, UnitHealth)
        {
        }

        public int CityDefence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
