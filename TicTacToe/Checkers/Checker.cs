﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Checkers
{
    public class Checker
    {
        public Color Color;
        public bool King = false;

        public Checker(Color color)
        {
            this.Color = color;
        }
    }
}
