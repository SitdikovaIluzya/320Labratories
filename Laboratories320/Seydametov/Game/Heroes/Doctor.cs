using Laboratories320.Seydametov.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    class Doctor : Heroes, IMove, IStrength, IHealTeammate, IScream
    {
        public Doctor(string UnitName, int UnitHealth) : base(UnitName, UnitHealth)
        {
        }

        public int Power { get => 50; set => throw new NotImplementedException(); }
        public int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void HealTeammate(Heroes teammate)
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
