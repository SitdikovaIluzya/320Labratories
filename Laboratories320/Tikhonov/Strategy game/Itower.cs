using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{ 
    interface Itower : IbaseUnit
    {
        int Damage { get; set; }
        void range_attak(IbaseUnit unit);

    }
}
