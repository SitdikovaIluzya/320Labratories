using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin
{
    class Barracks : Build //Барраки
    {
        public Barracks(string Name, int Health, int Level) : base(Name, Health, Level)
        {
            
        }

        public void Interface_RestoreWorkHealth()
        {
            Console.WriteLine("Здоровье героя восстановлено");
        }
    }
}
