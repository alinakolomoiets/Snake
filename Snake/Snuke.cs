﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snuke :Figure
	{
        public Direction direction;//хранение данных для движения
        public Snuke(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();// Задаем направление и начальную точку 
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
        internal void Move()// Реализация
		{
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();//стирает хвостовую точку
            head.Draw();
		}
        public Point GetNextPoint()//
		{
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
		}
        public void HandleKey(ConsoleKey key)//нажатие клавиш
		{
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
    }
}
