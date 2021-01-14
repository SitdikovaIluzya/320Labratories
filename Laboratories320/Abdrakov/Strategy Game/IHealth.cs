using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game
{
    interface IHealth
    {
        public int GetHealth();
        public void ChangeHealth(int deltaHealth);
    }
}
