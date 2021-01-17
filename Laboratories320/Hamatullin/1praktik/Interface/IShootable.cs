using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik.Interface
{
    interface IShootable
    {
        int Ammunition { get;}
        int Range { get;}
        void Shoot(Unit unit);
    }
}
