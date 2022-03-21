using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowSize(80, 25);
			//Выводим  рамку на экран 
			HorizontalLine upline = new HorizontalLine(0, 78, 0, '*');
			HorizontalLine downline = new HorizontalLine(0, 78, 24, '*');
			VerticalLine leftline = new VerticalLine(0, 24, 0, '*');
			VerticalLine rightline = new VerticalLine(0, 24, 78, '*');
			upline.Drow();
			downline.Drow();
			leftline.Drow();
			rightline.Drow();

			Point p = new Point(4, 5, '*');//Вывод точки на экран
			Snuke snuke = new Snuke(p, 4, Direction.RIGHT);
			snuke.Drow();

			while (true)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snuke.HandleKey(key.Key);
				}
				Thread.Sleep(100);
				snuke.Move();
			}
		}
	}
}
