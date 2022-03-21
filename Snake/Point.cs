using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point
	{
        public int x;//точки 
        public int y;
        public char sym;

        public Point()// пустой конструктор
        {
        }

        public Point(int _x, int _y, char _sym)//Конструктор указывающий координаты
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)// конструктор с помощью которого можно задавать точки с помощью другой точки
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)//Сдвигает точку по  заданому направлению
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
