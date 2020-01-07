using CardGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CardGame
{
	public class PlayingCardGame
	{
		private readonly Utility ut = new Utility();
		DataAccess dataAccess = new DataAccess();
		PlayingCardDeck PlayingCardDeck = new PlayingCardDeck();
		List<PlayingCard> cardDeck = new List<PlayingCard>();

		HighScore selectedPlayer;
		private bool endGame = false;

		public void PlayGame()
		{
			

			while (endGame == false)
			{
				GameMenu();
			}


		}


		public void CreateCardDeckAndScrambleCards()
		{
			cardDeck = PlayingCardDeck.CreateFullCardDeck();
			cardDeck = PlayingCardDeck.ScrambleCards(cardDeck);
		}


		public PlayingCard DrawFirstCard(List<PlayingCard> cardDeckToDrawfrom)
		{
			var firstCard = cardDeckToDrawfrom.First();
			var index = cardDeckToDrawfrom.IndexOf(firstCard);
			cardDeckToDrawfrom.RemoveAt(index);

			PutCardLast(cardDeckToDrawfrom, firstCard);

			return firstCard;
		}

		public void PutCardLast(List<PlayingCard> playingCards, PlayingCard card) => playingCards.Add(card);

		public void GameMenu()
		{
			ut.PL("M e n u");
			ut.PL("");
			ut.PL("[N]ew game");
			ut.PL("[H]igh scores");
			ut.PL("[R]ules");
			ut.PL();
			ut.PL("[Esc] - to end game");


			ConsoleKeyInfo consoleKey = Console.ReadKey(true);

			switch (consoleKey.Key)
			{
				case ConsoleKey.N:
					CreateCardDeckAndScrambleCards();
					SelectPlayerOrCreateNew();
					break;
				case ConsoleKey.H:
					Console.Clear();
					ShowHighScores();
					break;

				case ConsoleKey.R:
					Console.Clear();
					Rules();
					ut.PL();
					ut.PL();
					ut.AnimateText("Press any key to continue...");
					Console.ReadKey(true);
					Console.Clear();
					break;

				case ConsoleKey.Escape:
					endGame = true;
					break;

				default:
					Console.Clear();
					break;
			}




		}

		public void PlayingGameMenu()
		{
			Console.Clear();
			Console.OutputEncoding = Encoding.UTF8;
			bool keepGoing = true;
			int highScoreCount = 0;

			do
			{
				var drawnCard = DrawFirstCard(cardDeck);
				var nextCard = DrawFirstCard(cardDeck);

				ut.PL($"Currently playing: {selectedPlayer.Player}");
				ut.PL();
				ut.PL($"Current HighScore: {highScoreCount.ToString()}");
				ut.PL();
				ut.PL();
				ut.PL("< - - - H i g h e r  o r  L o w e r - - - >");
				ut.PL();
				ut.PL();
				ut.PL($"\t\t{drawnCard.CardValue} {drawnCard.Suit}");
				ut.PL();
				ut.PL("[H] - for higher\t-\t[L] - for lower");
				ut.PL();
				ut.PL();
				ut.PL();
				ut.PL("[Esc] - for main menu");


				//P(nextCard.ToString());

				ConsoleKeyInfo consoleKey = Console.ReadKey(true);
				switch (consoleKey.Key)
				{
					case ConsoleKey.H:
						if (nextCard.ValueIndex > drawnCard.ValueIndex || nextCard.ValueIndex == drawnCard.ValueIndex)
						{
							highScoreCount++;
							ut.AnimateText($"Card was: {nextCard.ToString()}");
							ut.PL();
							ut.AnimateText($"Score count increased by: {+1}");
							//dataAccess.UpdateHighScore(selectedPlayer.Player, selectedPlayer.Score);
						}
						else
						{
							ut.AnimateText("Wrong guess...");
							ut.PL();
							ut.AnimateText($"Card was: {nextCard.ToString()}");
							ut.PL();
							ut.AnimateText("Returning to main");
							ut.ThinkingDots();
							Thread.Sleep(100);
							keepGoing = false;
						}

						ut.PL();
						//ut.AnimateText("Press any key to continue");
						//Console.ReadKey(true);
						Console.Clear();
						break;

					case ConsoleKey.L:
						if (nextCard.ValueIndex < drawnCard.ValueIndex || nextCard.ValueIndex == drawnCard.ValueIndex)
						{
							highScoreCount++;
							ut.AnimateText($"Card was: {nextCard.ToString()}");
							ut.PL();
							ut.AnimateText($"Score count increased by: {+1}");
						}

						else
						{
							ut.AnimateText("Wrong guess...");
							ut.PL();
							ut.AnimateText($"Card was: {nextCard.ToString()}");
							ut.PL();
							ut.AnimateText($"Returning to main");
							ut.ThinkingDots();
							Thread.Sleep(100);
							keepGoing = false;
						}

						ut.PL();
						//ut.AnimateText("Press any key to continue");
						//Console.ReadKey(true);
						Console.Clear();
						break;

					case ConsoleKey.Escape:
						Console.Clear();
						keepGoing = false;
						GameMenu();
						break;

					default:
						Console.Clear();
						break;
				}

			} while (keepGoing);


			if (highScoreCount > selectedPlayer.Score)
			{
				selectedPlayer.Score = highScoreCount;
				dataAccess.UpdateHighScore(selectedPlayer.Player, selectedPlayer.Score);
			}

			GameMenu();
		}

		public void SelectPlayerOrCreateNew()
		{

			Console.Clear();
			ut.PL("[M] for menu");
			ut.PL();
			ut.PL("[S]elect Player");
			ut.PL();
			ut.PL("[N]ew Player?");


			ConsoleKeyInfo consoleKey = Console.ReadKey(true);
			switch (consoleKey.Key)
			{
				case ConsoleKey.S:
					Console.Clear();
					SelectPlayer();
					break;

				case ConsoleKey.N:
					ut.PL("Enter name: ");
					var newPlayerName = Console.ReadLine();
					dataAccess.SetNewPlayer(newPlayerName);
					ut.PL($"Welcome {newPlayerName}! Press any key to continue...");

					selectedPlayer = dataAccess.SelectedPlayer(newPlayerName);

					Console.ReadKey(true);
					PlayingGameMenu();
					break;

				case ConsoleKey.M:
					Console.Clear();
					GameMenu();

					break;

				default:
					break;
			}



		}

		public void SelectPlayer()
		{

			var playerToSelect = dataAccess.ShowPlayers();
			ut.PL("[Esc] - go back");
			ut.PL();
			ut.PL("Choose player:");
			ut.PL();
			ut.PL("ID  NAME");

			foreach (var item in playerToSelect)
				ut.PL(item.Id + "  " + item.Player);

			ut.PL("Player ID: ");
			string input3 = Console.ReadLine();

			Regex regex1 = new Regex("^[0-9]");
			Regex regexString = new Regex("^[A-Za-z]");

			if (regex1.IsMatch(input3))
				selectedPlayer = dataAccess.SelectedPlayer(int.Parse(input3));
			else if (regexString.IsMatch(input3))
				selectedPlayer = dataAccess.SelectedPlayer(input3);

			else if (input3.Equals(ConsoleKey.Escape))
			{
				SelectPlayerOrCreateNew();
			}

			ut.PL($"Welcome {selectedPlayer.Player}! Press any key to continue...");
			Console.ReadKey(true);
			PlayingGameMenu();

		}

		public void ShowHighScores()
		{

			Console.ForegroundColor = ConsoleColor.Green;
			ut.PL("H I G H S C O R E S");
			Console.ForegroundColor = ConsoleColor.White;

			ut.PL();
			var playerToSelect = dataAccess.ShowPlayers();
			ut.PL("ID\tNAME\tSCORE");

			var orderedList = playerToSelect
				.OrderByDescending(a => a.Score);

			foreach (var item in orderedList)
				ut.PL(item.Id + "\t" + item.Player + "\t" + item.Score);

			ut.PL();
			ut.AnimateText("Press any key to continue...");

			Console.ReadKey(true);
			Console.Clear();
			GameMenu();



		}


		public void Rules()
		{
			ut.AnimateText("Based on the card that's currently showing, the player has to guess whether the face-down card is higher or lower than the face-up card. " +
				"After the guess, the dealer flips the hidden card, and the answer is revealed. " +
	"If the guess was correct, the player wins and can choose to double or pass; if not, the player loses and the dealer moves on.");




		}


	}
}
