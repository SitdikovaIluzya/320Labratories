using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    class Workshop : UnitBuilding //мастерская
    {
        public Workshop(string Name, int Health, int Level, int OccupiedSpace) : base(Name, Health, Level, OccupiedSpace)
        {

        }

        public void MakeWeapon()
        {
            Console.WriteLine("Оружие изготовлено");
        }
    }
}
