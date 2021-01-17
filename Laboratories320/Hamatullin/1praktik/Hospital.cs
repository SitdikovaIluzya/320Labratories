using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Hospital : UnitBuilding,IHealeable
    {
        public int AmountHealingSubstances { get; set; }

        public Hospital(string Name,int Hp,int Width,int Length,int AmountHealingSubstances) : base (Name,Hp,Width,Length)
        {
            this.AmountHealingSubstances = AmountHealingSubstances;
        }

        public void Heal(WarUnit warUnit)
        {
            if (AmountHealingSubstances != 0)
            {
                AmountHealingSubstances -= 1;
                warUnit.Hp += 100;
            }
        }

        public void Heal(WorkerUnit workerUnit)
        {
            if (AmountHealingSubstances != 0)
            {
                AmountHealingSubstances -= 1;
                workerUnit.Hp += 100;
            }
        }
    }
}
