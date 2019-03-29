﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6ex3akshabaevbymyself
{
    public class Food:Gameobject
    {
        public Food(int x, int y, char sign, ConsoleColor color) : base(x, y, sign, color) { }

        public void Generate()
        {
            Random random = new Random();
            int x = random.Next(1, 100);
            int y = random.Next(1, 24);
            body[0].x = x;
            body[0].y = y;
        }
    }
}
