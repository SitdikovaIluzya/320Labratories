using System;
using System.Collections.Generic;
using System.Text;
using Laboratories320.Smirnov.StrategyGame_1_.Interfaces;

namespace Laboratories320.Smirnov.StrategyGame_1_.Units.War_units
{
    class Ninja : Unit, IDestroy, IAttack, IMove
    {
        public Ninja(string name, int health) : base(name, health)
        {

        }

        public void Attack(Unit unit)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
