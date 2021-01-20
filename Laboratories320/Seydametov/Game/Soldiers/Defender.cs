using Laboratories320.Seydametov.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Seydametov.StrategyGame
{
    class Defender : Heroes, IMove, IStrength, IArmor
    {
        public Defender(string UnitName, int UnitHealth) : base(UnitName, UnitHealth)
        {
        }

        public int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Move()
        {
            Console.WriteLine(this.Name + ": Moving");
            throw new NotImplementedException();
        }

       
    }
}
