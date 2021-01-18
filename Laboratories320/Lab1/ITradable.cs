using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    interface ITradable
    {
        public double Income { get; set; }
        public List<string> Products { get; set; }
        public void sell();
    }
}
