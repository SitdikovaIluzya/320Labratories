using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Mazitova.Pr1
{
    //Ремесленник
    class Artisan : Unit, IMovable
    {
        public string Rang { get; set; }
        public Artisan(string name, int health)
        : base(name, health)
        {

        }

        public void Move()
        {

        }
    }
}
