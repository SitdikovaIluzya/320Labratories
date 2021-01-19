using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    interface Ipaladin
    {
        
        int ArmorClass { get; set; }
        int Speed { get; set; }
        int Damage { get; set; }

        void melee_attack();
        void heal_ally(BaseUnit ally);
        void move();

    }

}
