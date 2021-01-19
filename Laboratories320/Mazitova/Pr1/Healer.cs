using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Mazitova.Pr1
{
    //Лекарь
    class Healer : Unit, IDamageable, IHealingable, IMovable
    {
        public Healer(string name, int health)
        : base(name, health)
        {

        }

        public void Damage(Unit units)
        {

        }

        public void Move()
        {
            
        }

        private void Healing(Unit unit1, Unit units2)
        {

        }
    }
}
