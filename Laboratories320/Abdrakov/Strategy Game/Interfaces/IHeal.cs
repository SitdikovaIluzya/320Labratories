using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game.Interfaces
{
    // Лечение или восстановление
    interface IHeal
    {
        public int healPower { get; }

        public void Heal(Unit target);
    }
}
