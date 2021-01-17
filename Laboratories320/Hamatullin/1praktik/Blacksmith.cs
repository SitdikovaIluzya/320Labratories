using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Blacksmith : WorkerUnit, IReplenishable
    {
        public Blacksmith(string Name, int Hp, int Speed) : base(Name, Hp, Speed)
        {

        }

        public void Replenish(IKeepable keepable)
        {
            if (keepable is Armory)
            {
                keepable.NumberMaterial += 50;
                Console.WriteLine("Пополнено на 50 материалов");
            }
            else
            {
                Console.WriteLine("Я не умею делать лечащие вещества");
            }

        }
    }
}