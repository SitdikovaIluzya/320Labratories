using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik.Interface
{
    interface IMoveable
    {
        int Speed { get; set; }
        void Move();
        void Carry(Unit unit);

    }
}
