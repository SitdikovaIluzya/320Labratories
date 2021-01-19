using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    interface Iwizard
    {
        int HitPoints { get; set; }
        int Speed { get; set; }
        int Damage { get; set; }
        void range_attak();
        void heal_ally();
    }
}
