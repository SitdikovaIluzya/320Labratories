using Laboratories320.Abdrakov.Strategy_Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game
{
    abstract class Unit : IHealth, ILocation, IDestruction
    {
        public abstract int X { get; protected set; }
        public abstract int Y { get; protected set; }
        public abstract int health { get; protected set; }

        public abstract void ChangeHealth(int deltaHealth);
        public abstract void Destruct();
    }
}
