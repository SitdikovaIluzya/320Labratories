using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game.Classes
{
    // Башня с лучником
    class ArcherTower : Unit, IAttack
    {
        public override int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack(Unit target, int damage, int attackRange)
        {
            throw new NotImplementedException();
        }

        public override void ChangeHealth(int deltaHealth)
        {
            throw new NotImplementedException();
        }

        public override int GetHealth()
        {
            throw new NotImplementedException();
        }
    }
}
