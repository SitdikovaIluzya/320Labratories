using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Hero : IMovable, IDestroyable
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public int NumberOfLife { get; set; }

        public void Move()
        {

        }

        public void Destroy()
        {

        }
    }
}
