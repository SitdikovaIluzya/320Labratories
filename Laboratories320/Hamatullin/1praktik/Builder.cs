using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Builder : WorkerUnit, IFix
    {
        public Builder(string Name, int Hp, int Speed) : base(Name, Hp, Speed)
        {

        }

        public void RepairBuild(UnitBuilding unitBuilding)
        {
            unitBuilding.Hp += 50;
            Console.WriteLine("Починено на +50 единиц");
        }
    }
}
