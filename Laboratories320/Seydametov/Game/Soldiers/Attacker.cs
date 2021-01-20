using Laboratories320.Seydametov.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    class Attacker : Heroes, IDamageEnemy, IMove, IStrength, IScream
    {
        public Attacker(string UnitName, int UnitHealth) : base(UnitName, UnitHealth)
        {
        }
        
        
        public int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DamageEnemy(Heroes enemy)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            Console.WriteLine(this.Name + ": Moving");
            throw new NotImplementedException();
        }

        public void Scream()
        {
            throw new NotImplementedException();
        }
    }
}
