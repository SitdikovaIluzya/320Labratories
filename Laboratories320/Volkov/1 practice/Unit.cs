using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Volkov._1_practice
{
    public  abstract class Unit
    {
        internal string Name { get; }
        internal int Health { get; set; }
        public Unit(string name, int health)
        {
            Name = name;
            Health = health;
        }
    }
}
