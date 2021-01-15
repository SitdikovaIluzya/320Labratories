using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game
{
    // Атака
    interface IAttack
    {
        public int attackRange { get; }
        public int damage { get; }

        public void Attack(Unit target);
    }
}
