using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320
{
    class Building : IDestroyable
    {
        public string Material { get; set; }
        public int Capacity { get; set; }

        public void Destroy()
        {

        }
    }
}
