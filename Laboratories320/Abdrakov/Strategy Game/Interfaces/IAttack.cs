using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game
{
    interface IAttack
    {
        public void Attack(Unit target, int damage, int attackRange);
    }
}
