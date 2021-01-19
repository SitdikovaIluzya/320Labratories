using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Mazitova.Pr1
{
    //Атакующий 
    class DamageDealer : Unit, IDamageable, IMovable
    {
        public DamageDealer (string name, int health) 
            : base (name, health)
        {

        }

        public void Damage(Unit units)
        {
            
        }

        public void Move()
        {

        }
    }
}
