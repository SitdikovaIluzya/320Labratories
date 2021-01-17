using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    abstract class UnitBuilding : Unit
    {
        public int Level { get; set; } //уровень
        public int OccupiedSpace { get; set; } //занимаемое место, в ячейках
        
        public UnitBuilding(string Name, int Health, int Level, int OccupiedSpace) : base (Name, Health)
        {
            this.Level = Level;
            this.OccupiedSpace = OccupiedSpace;
        }
    }
}
