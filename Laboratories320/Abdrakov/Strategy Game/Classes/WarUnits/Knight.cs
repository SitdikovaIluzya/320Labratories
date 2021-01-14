using Laboratories320.Abdrakov.Strategy_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game.Classes.WarUnits
{
    class Knight : Unit, IMove, IAttack, IArmor
    {
        public override int X { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override int Y { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override int health { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public int armor { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

        public void Attack(Unit target, int damage, int attackRange)
        {
            throw new NotImplementedException();
        }

        public void ChangeArmor(int deltaArmor)
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
