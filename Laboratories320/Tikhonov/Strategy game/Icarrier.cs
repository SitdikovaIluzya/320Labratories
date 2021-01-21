using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    interface Icarrier : IbaseUnit
    {
        

            int Speed { get; set; }
            void carry();
            void move();
    }
}

