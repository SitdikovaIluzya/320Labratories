using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    interface Iminer : IbaseUnit
    {
        int Speed { get; set; }
        void mine();
        void move();
    }
}
