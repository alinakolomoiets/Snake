using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snuke :Figure
	{
        Direction direction;//хранение данных для движения
        public Snuke(Point tail, int length, Direction direction)
        {
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

            tail.Clear();
            head.Draw();
		}
        public Point GetNextPoint()//
		{
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
		}
    }
}
