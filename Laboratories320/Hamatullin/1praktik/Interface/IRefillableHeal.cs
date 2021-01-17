using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik.Interface
{
    interface IRefillableHeal
    {
        int AmountHealingSubstances { get; set; }
        void RefillHeal(Hospital hospital);
    }
}
