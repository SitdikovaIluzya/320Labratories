using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game
{
    interface IHealth
    {
        public int health { get; }

        public void ChangeHealth(int deltaHealth);
    }
}
