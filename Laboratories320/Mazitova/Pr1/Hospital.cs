using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Mazitova.Pr1
{
    class Hospital : Unit, IHealingable
    {
        //Больница
        public Hospital(string name, int health)
            : base(name, health)
        {

        }
        private void Healing(Unit unit1, Unit units2)
        {

        }
    }
}
