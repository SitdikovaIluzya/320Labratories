using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Archer : CharacteristicWarnior, IWarrior
    {
        public Archer(int health, int uron)
        {
            _health = health;
            _uron = uron;
        }
        public void Axe()
        {
            Console.WriteLine("Archer axe");
        }
        public void Grenade()
        {
            Console.WriteLine("Archer grenade");
        }
    }
}
