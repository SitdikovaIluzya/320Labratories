using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin
{
    class Workshop : Build //мастерская
    {
        public Workshop(string Name, int Health, int Level) : base(Name, Health, Level)
        {

        }

        public void Make()
        {
            Console.WriteLine("Оружие изготовлено");
        }
    }
}
