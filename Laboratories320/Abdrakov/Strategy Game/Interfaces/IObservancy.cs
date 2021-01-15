using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game.Interfaces
{
    // Наблюдательность
    interface IObservancy
    {
        public int observancy { get; }

        public bool SeeTheEnemy(Unit target);
        public void ChangeObservancy(int deltaObs);
    }
}
