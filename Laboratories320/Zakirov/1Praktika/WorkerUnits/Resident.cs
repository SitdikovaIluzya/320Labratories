using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    class Resident : WorkerUnit //житель
    {
        public Resident(string Name, int Health, int SpeedConstruction, int Speed) : base(Name, Health, SpeedConstruction, Speed)
        {

        }

        public void FollowVillage()
        {
            Console.WriteLine("Следит за деревней");
        }
    }
}
