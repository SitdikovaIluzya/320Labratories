using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Healer : WarUnit, IRefillableHeal
    {
        public int AmountHealingSubstances { get; set; } = 20;

        public Healer(string Name, int Hp, int Speed, int Armor) : base(Name, Hp, Speed, Armor)
        {
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

        public void RefillHeal(Hospital hospital)
        {
            if (hospital.NumberMaterial > 20)
            {
                Console.WriteLine("Пополнение лечащих веществ");
                for (int i = 0; i < AmountHealingSubstances; i++)
                {
                    AmountHealingSubstances += 1;
                }
            }
            else
            {
                Console.WriteLine($"Нехватка лечащих веществ в {hospital.Name}");
            }
        }
    }
}
