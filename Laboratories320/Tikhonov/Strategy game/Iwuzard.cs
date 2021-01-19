using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    interface Iwizard : IbaseUnit
    {
        int Speed { get; set; }
        int Damage { get; set; }
        void range_attak(IbaseUnit unit);
        void heal_ally(IbaseUnit unit);
        void move();
    }
}
