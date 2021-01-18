using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Archers : WarUnit, IShootable
    {
        public string Weapon { get; set; }
        public int ShootRange { get; set; }

        public void Shoot()
        {

        }
    }
}
