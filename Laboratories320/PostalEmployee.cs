using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class PostalEmployee : CharacteristicisWorker, IWorker
    {
        public PostalEmployee(int health, int money)
        {
            _health = health;
            _money = money;
        }
        public void Cook()
        {
            Console.WriteLine("Postal Employee cooking");
        }
        public void Move()
        {
            Console.WriteLine("Postal Employee Moving");
        }
        public void Eat()
        {
            Console.WriteLine("Postal Employee eating");
        }
    }
}
