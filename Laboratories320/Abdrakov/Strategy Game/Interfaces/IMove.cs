﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratories320.Abdrakov.Strategy_Game
{
    // Перемещение
    interface IMove
    {
        public void Move(int dx, int dy);
    }
}
