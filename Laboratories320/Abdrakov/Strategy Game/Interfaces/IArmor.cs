using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game.Interfaces
{
    interface IArmor
    {
        public int armor { get; }

        public void ChangeArmor(int deltaArmor);
    }
}
