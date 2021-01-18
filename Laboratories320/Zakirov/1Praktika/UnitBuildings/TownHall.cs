using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    class TownHall : UnitBuilding, IRestoreWorkerHealth //ратуша
    {
        public TownHall(string Name, int Health, int Level, int OccupiedSpace) : base(Name, Health, Level, OccupiedSpace)
        {

        }

        public void RestoreWorkerHealth()
        {
            Console.WriteLine("Здоровье рабочего восстановлено");
        }
    }
}
