using Laboratories320.Abdrakov.Strategy_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game.Classes
{
    // Башня с лучником
    class ArcherTower : Unit, IAttack, IObservancy
    {
        public override int X { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override int Y { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override int health { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public int attackRange { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public int damage { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public int observancy { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

        public void Attack(Unit target)
        {
            throw new NotImplementedException();
        }

        public override void ChangeHealth(int deltaHealth)
        {
            throw new NotImplementedException();
        }

        public void ChangeObservancy(int deltaObs)
        {
            throw new NotImplementedException();
        }

        public bool SeeTheEnemy(Unit target)
        {
            throw new NotImplementedException();
        }
    }
}
