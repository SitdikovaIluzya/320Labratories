using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    class Builder : Heroes, IStrength, IMove, IRepairBuild
    {
        public Builder(string UnitName, int UnitHealth) : base(UnitName, UnitHealth)
        {
        }

        public int Power { get => 50; set => throw new NotImplementedException(); }
        public int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void RepairBuild(Heroes build)
        {
            throw new NotImplementedException();
        }

        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
}
