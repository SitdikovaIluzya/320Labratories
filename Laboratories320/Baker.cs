using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Baker : CharacteristicisWorker, IWorker
    {
        public Baker(int health, int money)
        {
            _health = health;
            _money = money;
        }
        public void Cook()
        {
            Console.WriteLine("Baker cooking");
        }
        public void Move()
        {
            Console.WriteLine("Baker Moving");
        }
        public void Eat()
        {
            Console.WriteLine("Baker eating");
        }
    }
}
