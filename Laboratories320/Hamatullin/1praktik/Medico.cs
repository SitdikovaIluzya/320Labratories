using Laboratories320.Hamatullin._1praktik.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Hamatullin._1praktik
{
    class Medico : WorkerUnit, IReplenishable
    {
        public Medico(string Name, int Hp, int Speed) : base(Name, Hp, Speed)
        {

        }

        public void Replenish(IKeepable keepable)
        {
            keepable.NumberMaterial += 10;
            Console.WriteLine("Пополнено на 10 материалов");
        }
    }
}
