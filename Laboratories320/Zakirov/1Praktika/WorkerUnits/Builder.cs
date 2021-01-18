using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    class Builder : WorkerUnit //строитель
    {
        public Builder(string Name, int Health, int SpeedConstruction, int Speed) : base(Name, Health, SpeedConstruction, Speed)
        {

        }

        public void Work()
        {
            Console.WriteLine("Работает");
        }
    }
}
