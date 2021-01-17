using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik.Interface
{
    interface IHealeable
    {
        void Heal(WarUnit warUnit);
        void Heal(WorkerUnit workerUnit);
    }
}
