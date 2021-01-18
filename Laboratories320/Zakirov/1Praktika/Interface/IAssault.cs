using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Zakirov._1Praktika
{
    interface IAssault //нападение
    {
        void Assault();
        int DamageDone { get; set; }
    }
}
