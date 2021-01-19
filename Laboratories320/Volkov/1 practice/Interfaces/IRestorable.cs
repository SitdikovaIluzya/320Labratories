using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Volkov._1_practice.Interfaces
{
    public interface IRestorable
    {
        public void Restore(Building.Catapult catapult);
        public void Restore(Building.Ram ram);
        public void Restore(Building.Scorion scorion);
    }
}
