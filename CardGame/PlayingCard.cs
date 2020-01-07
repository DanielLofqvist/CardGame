using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
	public class PlayingCard
	{
		//public enum Suit { ace = 0, one = 1, two = 2, three = 3, four = 4, five = 5, six = 6, seven = 7, eight = 8, nine = 9, ten = 10, jack = 11, queen = 12, king = 13  }
		
		//public string heart = "♥";
		//public string club = "♣";
		//public string spade = "♥";
		//public string diamond = "♦";

		public int ValueIndex { get; set; }
		public string CardValue { get; set; }
		public string Suit { get; set; }


		public static List<PlayingCard> playingCard = new List<PlayingCard>()
		{
			new PlayingCard{ ValueIndex = 1, CardValue = "ace" },
			new PlayingCard{ ValueIndex = 2, CardValue = "two" },
			new PlayingCard{ ValueIndex = 3, CardValue = "three" },
			new PlayingCard{ ValueIndex = 4, CardValue = "four" },
			new PlayingCard{ ValueIndex = 5, CardValue = "five" },
			new PlayingCard{ ValueIndex = 6, CardValue = "six" },
			new PlayingCard{ ValueIndex = 7, CardValue = "seven" },
			new PlayingCard{ ValueIndex = 8, CardValue = "eight" },
			new PlayingCard{ ValueIndex = 9, CardValue = "nine" },
			new PlayingCard{ ValueIndex = 10, CardValue = "ten" },
			new PlayingCard{ ValueIndex = 11, CardValue = "jack" },
			new PlayingCard{ ValueIndex = 12, CardValue = "queen" },
			new PlayingCard{ ValueIndex = 13, CardValue = "king" }

		};


		public override string ToString()
		{
			Console.OutputEncoding = Encoding.UTF8;
			return $"{CardValue} - {Suit}";
		}

	}
}
