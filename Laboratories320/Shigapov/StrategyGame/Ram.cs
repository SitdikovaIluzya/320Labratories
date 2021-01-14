using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Shigapov.StrategyGame
{
    class Ram : Unit , IAttack, IHeal //Таран
    {
        public int Damage { get; set; } = 100;
        public override int Health { get; set; } = 200;

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
