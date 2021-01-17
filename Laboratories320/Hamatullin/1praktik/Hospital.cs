using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Hospital : UnitBuilding, IHealeable, IKeepable
    {
        public int NumberMaterial { get; set; } = 100;
        public Hospital(string Name, int Hp, int Width, int Length) : base(Name, Hp, Width, Length)
        {

        }
        public void Heal(WarUnit warUnit)
        {
            warUnit.Hp += 100;
        }

        public void Heal(WorkerUnit workerUnit)
        {
            workerUnit.Hp += 100;
        }
    }
}
