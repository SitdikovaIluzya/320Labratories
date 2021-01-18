using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    abstract class Unit
    {
        internal string Name { get; set; } // название юнита
        internal int Health { get; set; } // здоровье юнита ( у зданий тоже может быть )

        public Unit (string name, int health)
        {
            this.Name = name;
            this.Health = health;
        }
    }
}
