﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine: Figure
	{
        public VerticalLine(int yUP, int yDown, int x, char sym) // Создаем вертикальные линии 
        {
            pList = new List<Point>();
            for (int y = yUP; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
