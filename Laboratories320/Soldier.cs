using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Soldier : CharacteristicWarnior, IWarrior
    {
        public Soldier(int health, int uron)
        {
            _health = health;
            _uron = uron;
        }
        public void Axe()
        {
            Console.WriteLine("Soldier axe");
        }
        public void Grenade()
        {
            Console.WriteLine("Soldier grenade");
        }
    }
}
