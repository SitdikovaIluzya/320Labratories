using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    interface IOperatable
    {
        public double Speed { get; set; }
        public void Transfer();
        public void Build();
    }
}
