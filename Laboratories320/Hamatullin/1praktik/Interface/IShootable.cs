using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik.Interface
{
    interface IShootable
    {
        int Ammunition { get; set; }
        int Range { get;}
        void Shoot(Unit unit);
        void ReplenishAmmunition(Armory armory);
    }
}
