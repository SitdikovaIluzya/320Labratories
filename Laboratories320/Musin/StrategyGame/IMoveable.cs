﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Musin.StrategyGame
{
    interface IMoveable
    {
        public int X { get; set; }
        public int Y { get; set; }
        void Move();
    }
}
