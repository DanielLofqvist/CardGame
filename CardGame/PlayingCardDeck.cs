using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardGame.PlayingCard;

namespace CardGame
{
	public class PlayingCardDeck
	{
		public Random randomNumber = new Random();

		//List<PlayingCard> cardlist = new List<PlayingCard>();


		public List<PlayingCard> CreateFullCardDeck()
		{
			var listOfCards = new List<PlayingCard>();

			for (int i = 0; i < 1; i++)
			{
				for (int j = 0; j < 13; j++)
					listOfCards.Add(new PlayingCard { Suit = "♥", ValueIndex = playingCard[j].ValueIndex, CardValue = playingCard[j].CardValue });
				for (int u = 0; u < 13; u++)
					listOfCards.Add(new PlayingCard { Suit = "♣", ValueIndex = playingCard[u].ValueIndex, CardValue = playingCard[u].CardValue });
				for (int o = 0; o < 13; o++)
					listOfCards.Add(new PlayingCard { Suit = "♦", ValueIndex = playingCard[o].ValueIndex, CardValue = playingCard[o].CardValue });
				for (int b = 0; b < 13; b++)
					listOfCards.Add(new PlayingCard { Suit = "♠", ValueIndex = playingCard[b].ValueIndex, CardValue = playingCard[b].CardValue });
			}

			return listOfCards;
		}

		public void PutCardAtTheEnd(List<PlayingCard> card)
		{

		}

		public PlayingCard GetFirstCard(PlayingCard playingCardDeck)
		{
			return null;
		}


		public List<PlayingCard> ScrambleCards(List<PlayingCard> playingCards)
		{
			var scrambledCardList = new List<PlayingCard>();

			while (scrambledCardList.Count < 52)
			{
				for (int i = 0; i < playingCards.Count; i++)
				{
					int rnd = randomNumber.Next(0, 52);

					if (rnd == i)
					{
						scrambledCardList.Add(playingCards[i]);
						playingCards.RemoveAt(i);
					}continue;
				}
			}

			return scrambledCardList;
		}



	}
}
