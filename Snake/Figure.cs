using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	internal class Figure
	{
        protected List<Point> pList;

        public void Drow()//Вывод точек на экран 
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
