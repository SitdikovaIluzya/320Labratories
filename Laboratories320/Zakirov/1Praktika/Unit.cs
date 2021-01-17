using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    abstract class Unit
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Unit(string Name, int Health)
        {
            this.Name = Name;
            this.Health = Health;
        }
    }
}
