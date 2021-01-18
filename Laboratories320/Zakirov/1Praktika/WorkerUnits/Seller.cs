using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    class Seller : WorkerUnit //продавец
    {
        public Seller(string Name, int Health, int SpeedConstruction, int Speed) : base(Name, Health, SpeedConstruction, Speed)
        {
            
        }

        public void SellAccessories()
        {
            Console.WriteLine("Продает предмет");
        }
    }
}
