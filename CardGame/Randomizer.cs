using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
	class Randomizer
	{

		public Random random = new Random();

		public int GetRandomNumber() 
		{
		
			int randomizedNumber = random.Next(1, 13);
			return randomizedNumber;
		}


	}
}
