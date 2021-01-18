using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin
{
    abstract class Units
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Units(string Name, int Health)
        {
            this.Name = Name;
            this.Health = Health;
        }
    }
}
