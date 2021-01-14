using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    class Tanker : Unit, IAttack, IHeal//Танк
    {
        public int Damage { get; set; } = 500;
        public override int Health { get; set; } = 1000;

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
