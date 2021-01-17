using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Healer : WarUnit,IHealeable
    {
        public int AmountHealingSubstances { get; set; }

        public Healer(string Name, int Hp, int Speed, int Armor,int AmountHealingSubstances) : base (Name,Hp,Speed,Armor)
        {
            this.AmountHealingSubstances = AmountHealingSubstances;
        }

        public void Heal(WarUnit warUnit)
        {
            if (AmountHealingSubstances != 0)
            {
                AmountHealingSubstances -= 1;
                warUnit.Hp += 10;
            }
        }

        public void Heal(WorkerUnit workerUnit)
        {
            if (AmountHealingSubstances != 0)
            {
                AmountHealingSubstances -= 1;
                workerUnit.Hp += 10;
            }
        }
    }
}
