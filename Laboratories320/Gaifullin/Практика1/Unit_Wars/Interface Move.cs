using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Gaifullin
{
    interface Interface_Move // Передвигаться
    {
        public int W { get; set; }
        public int S { get; set; }
        void Move();
    }
}
