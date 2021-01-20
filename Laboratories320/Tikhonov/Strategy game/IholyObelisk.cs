using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Tikhonov.Strategy_game
{
    interface IholyObelisk : IbaseUnit
    {
        int Damage { get; set; }
        void heal_ally(IbaseUnit unit);
    }
}
