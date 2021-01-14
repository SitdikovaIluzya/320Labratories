using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game
{
    abstract class Unit : IHealth, ILocation
    {
        public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract void ChangeHealth(int deltaHealth);

        public abstract int GetHealth();
    }
}
