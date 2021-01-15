using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game.Classes.WarUnits
{
    class Archer : Unit, IAttack, IMove
    {
        public override int X { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override int Y { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override int health { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public int attackRange { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public int damage { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

        public void Attack(Unit target)
        {
            throw new NotImplementedException();
        }

        public override void ChangeHealth(int deltaHealth)
        {
            throw new NotImplementedException();
        }

        public void Move(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}
