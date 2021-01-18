using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Guard : CharacteristicWarnior, IWarrior
    {
        public Guard(int health, int uron)
        {
            _health = health;
            _uron = uron;
        }
        public void Axe()
        {
            Console.WriteLine(" Guard axe");
        }
        public void Grenade()
        {
            Console.WriteLine("Guard grenade");
        }
    }
}
