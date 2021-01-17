using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik.Interface
{
    interface IRechargable
    {
        int Ammunition { get; set; }
        void ReplenishAmmunition(Armory armory);
    }
}
