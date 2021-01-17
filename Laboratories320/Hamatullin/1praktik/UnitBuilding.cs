using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    abstract class UnitBuilding : Unit,IConstructed
    {
        public UnitBuilding(string Name,int Hp,int Width,int Length) : base (Name,Hp)
        {
            this.Width = Width;
            this.Length = Length;
        }

        public int Width { get; set; }
        public int Length { get; set; }
    }
}
