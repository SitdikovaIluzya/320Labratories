using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Farmer : CharacteristicisWorker, IWorker
    {
        public Farmer(int health, int money)
        {
            _health = health;
            _money = money;
        }
        public void Cook()
        {
            Console.WriteLine("Farmer cooking");
        }
        public void Move()
        {
            Console.WriteLine("Farmer Moving");
        }
        public void Eat()
        {
            Console.WriteLine("Farmer eating");
        }
    }
}
