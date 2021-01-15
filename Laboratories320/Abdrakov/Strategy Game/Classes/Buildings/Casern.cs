using Laboratories320.Abdrakov.Strategy_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game.Classes
{
    // Казарма
    class Casern : Unit, IHeal
    {
        public override int X { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override int Y { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override int health { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public int healPower { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

        public override void ChangeHealth(int deltaHealth)
        {
            throw new NotImplementedException();
        }

        public override void Destruct()
        {
            throw new NotImplementedException();
        }

        public void Heal(Unit target)
        {
            throw new NotImplementedException();
        }
    }
}
