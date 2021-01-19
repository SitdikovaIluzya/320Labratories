using Laboratories320.Volkov._1_practice.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Volkov._1_practice.War_Units
{
    class Swordsman : Unit, IAttackable, IMoveable, IDefendable, IDestroy
    {
        public void GetDamage(Unit unit)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Defend(Unit unit)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public Swordsman(string name, int health) : base(name, health)
        {

        }
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
