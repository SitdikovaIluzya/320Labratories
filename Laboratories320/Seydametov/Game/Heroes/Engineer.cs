using Laboratories320.Seydametov.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    class Engineer : Heroes, IScream, IAddArmor, IMove, IStrength

    {
        public Engineer(string UnitName, int UnitHealth, int UnitProtection) : base(UnitName, UnitHealth)
        {
        }

        public int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddArmor(IArmor teammate)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Scream()
        {
            throw new NotImplementedException();
        }
    }
}
