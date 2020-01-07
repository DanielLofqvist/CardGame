using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CardGame
{
	public class Utility
	{

		public void AnimateText(string textToAnimate)
		{

			foreach (char item in textToAnimate)
			{
				Console.Write(item.ToString());
				Thread.Sleep(20);
			}

		}

		public void PL(string text) => Console.WriteLine(text);
		public void PL() => Console.WriteLine();

		public void P(string text) => Console.Write("");


		public void ThinkingDots()
		{
			string dots = "...";
			for (int i = 0; i < 4; i++)
			{
				foreach (char item in dots)
				{
					Console.Write(item.ToString());
					Thread.Sleep(150);
				}

			}

		}



	}
}
