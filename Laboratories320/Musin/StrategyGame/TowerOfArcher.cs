using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Musin.StrategyGame
{
    class TowerOfArcher : UnitBuilding, IAttackable, IDamageble
    {
        public override int Health { get; set; } = 1000;
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
