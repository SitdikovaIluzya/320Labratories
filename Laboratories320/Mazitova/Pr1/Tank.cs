using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Mazitova.Pr1
{
    // Защитник
    class Tank : Unit, IDamageable, IMovable, IShootable
    {
        public Tank(string name, int health)
           : base(name, health)
        {

        }

        public void Damage(Unit units)
        {
           
        }

        public void Move()
        {
           
        }

        public void Shoot()
        {
            
        }
    }
}
