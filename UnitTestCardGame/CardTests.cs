using System;
using Xunit;
using CardGame;
using System.Collections.Generic;

namespace UnitTestCardGame
{
	public class CardTests
	{
		[Fact]
		public void TestAnimateText()
		{
			//Arrange
			var ut = new Utility();
			string text = "Starbucks coffie";

			//Act 
			//playingCardGame.AnimateText(text);
			ut.AnimateText(text);

			//Assert
			Assert.Equal("Starbucks coffie", text);


		}


		public void TestHighScores()
		{

			//Arrange
			var playingCardGame = new PlayingCardGame();



			//Act
			playingCardGame.ShowHighScores();


			//Assert
			





		}












	}
}
