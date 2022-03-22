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
			Walls walls = new Walls(80, 25);
			walls.Draw();

			Point p = new Point(4, 5, '*');//Вывод точки на экран
			Snuke snuke = new Snuke(p, 4, Direction.RIGHT);
			snuke.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '%');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while (true)
			{
				if (walls.IsHit(snuke) || snuke.IsHitTail())
				{
					break;
				}
				if (snuke.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snuke.Move();
				}
				Thread.Sleep(100);

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snuke.HandleKey(key.Key);
				}
			}
		}
	}
}