using Laboratories320.Seydametov.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    class Sniper : Heroes, IStrength, IDamageEnemy, IMove, IScream, IArmor

    {
        int gStrength;
        public Sniper(string UnitName, int UnitHealth, int gStrength) : base(UnitName, UnitHealth )
        {
            this.gStrength = gStrength;
        }

        public int Strength { get => this.gStrength; set => throw new NotImplementedException(); }
        public int Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DamageEnemy(Heroes enemy)
        {
            enemy.Health -= this.gStrength;
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
    

