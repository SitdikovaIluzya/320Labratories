using Laboratories320.Shigapov.StrategyGame.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    class WarUnit : Unit , IAttack,IMove
    {
        public int Speed { get; set; }
        public int Armor { get; set; }
        public override int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Damage => throw new NotImplementedException();

        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
