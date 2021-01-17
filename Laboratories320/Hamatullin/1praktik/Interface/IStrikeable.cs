using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik.Interface
{
    interface IStrikeable : IToDamageble
    {
        void Strike(Unit unit);
    }
}
