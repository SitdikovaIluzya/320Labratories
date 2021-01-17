using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Armory : UnitBuilding, IKeepable
    {
        public int NumberMaterial { get; set; } = 1000;
        public Armory(string Name, int Hp, int Width, int Length) : base(Name, Hp, Width, Length)
        {

        }
    }
}
