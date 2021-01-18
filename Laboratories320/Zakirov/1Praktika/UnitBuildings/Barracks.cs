using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    class Barracks : UnitBuilding //казарма
    {
        public Barracks(string Name, int Health, int Level, int OccupiedSpace) : base(Name, Health, Level, OccupiedSpace)
        {
            
        }

        public void RestoreHeroHealth()
        {
            Console.WriteLine("Здоровье героя восстановлено");
        }
    }
}
