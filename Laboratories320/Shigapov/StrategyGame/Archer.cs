using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    class Archer : Unit, IAttack, IHeal//Лучник
    {
        public int Damage { get; set; } = 50;
        public override int Health { get; set; } = 100;

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }
    }
}
