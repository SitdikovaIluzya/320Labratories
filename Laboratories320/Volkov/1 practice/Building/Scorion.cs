using Laboratories320.Volkov._1_practice.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Volkov._1_practice.Building
{
    public class Scorion : IAttackable, IDestroy, IDefendable
    {
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Defend(Unit unit)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
