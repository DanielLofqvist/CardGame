using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class DeadMethods
    {

		//public void ScrambleCards()
		//{
		//	//	foreach (var item in playingCard)
		//	//		Console.WriteLine(item.ValueIndex + " " + item.Suit);

		//	int[] tempNo = new int[52];
		//	randomNumber = new Random();

		//	int H = 0;
		//	int D = 1;
		//	int S = 2;
		//	int C = 3;

		//	for (int i = 0; i < cardlist.Count; i++)
		//	{
		//		int num = randomNumber.Next(0, 52);
		//		for (int j = 0; j < cardlist.Count; j++)
		//		{
		//			//for (int k = 0; k < tempNo.Length; k++)
		//			//	if (tempNo[j] == num)
		//			//		num = randomNumber.Next(0, 52);

		//			if (num == cardlist[j].ValueIndex)
		//			{
		//				var tmpPlayingCard = cardlist[j];
		//				cardlist.RemoveAt(j);
		//				cardlist.Add(tmpPlayingCard);
		//				tempNo[j] += num;
		//			}
		//		}
		//	}

		//	Console.WriteLine();
		//	Console.WriteLine("----------------------------------");
		//	Console.WriteLine();
		//	foreach (var item in cardlist)
		//		Console.WriteLine(item.ValueIndex + " " + item.Suit + " " + item.Color);


		//}

		// ScrambleCards remastered
		//--------------------------------------------------------------------------


		//public void ScrambleCards()
		//{
		//	//	foreach (var item in playingCard)
		//	//		Console.WriteLine(item.ValueIndex + " " + item.Suit);

		//	int[] tempNo = new int[550];
		//	randomNumber = new Random();

		//	//int H = 0;
		//	//int D = 1;
		//	//int S = 2;
		//	//int C = 3; 


		//	for (int i = 0; i < cardlist.Count; i++)
		//	{
		//		int num = randomNumber.Next(0, 13);
		//		//int letter = randomNumber.Next(0, 3);
		//		for (int j = 0; j < cardlist.Count; j++)
		//		{
		//			//for (int k = 0; k < tempNo.Length; k++)
		//			//	if (tempNo[j] == num)
		//			//		num = randomNumber.Next(0, 52);

		//			if (num == cardlist[j].ValueIndex && cardlist[j].Color.Equals("H"))
		//			{
		//				var tmpPlayingCard = cardlist[j];
		//				cardlist.RemoveAt(j);
		//				//cardlist.Where(a => a.Color == "H");
		//				cardlist.Add(tmpPlayingCard);
		//				tempNo[j] += num;
		//			}
		//			else if (num == cardlist[j].ValueIndex && cardlist[j].Color.Equals("S"))
		//			{
		//				var tmpPlayingCard = cardlist[j];
		//				cardlist.RemoveAt(j);
		//				//cardlist.Where(a => a.Color == "S");
		//				cardlist.Add(tmpPlayingCard);
		//				tempNo[j] += num;
		//			}
		//			else if (num == cardlist[j].ValueIndex && cardlist[j].Color.Equals("C"))
		//			{
		//				var tmpPlayingCard = cardlist[j];
		//				cardlist.RemoveAt(j);
		//				//cardlist.Where(a => a.Color == "C");
		//				cardlist.Add(tmpPlayingCard);
		//				tempNo[j] += num;
		//			}
		//			else if (num == cardlist[j].ValueIndex && cardlist[j].Color.Equals("D"))
		//			{
		//				var tmpPlayingCard = cardlist[j];
		//				cardlist.RemoveAt(j);
		//				//cardlist.Where(a => a.Color == "D" && a.ValueIndex.Equals(j));
		//				cardlist.Add(tmpPlayingCard);
		//				tempNo[j] += num;
		//			}

		//		}
		//	}

		//	Console.WriteLine();
		//	Console.WriteLine("----------------------------------");
		//	Console.WriteLine();
		//	foreach (var item in cardlist)
		//		Console.WriteLine(item.ValueIndex + " " + item.Suit + " " + item.Color);

		//}


//--------------------------------------------------------------

		//public void ScrambleCardsTwo()
		//{
		//	var newCardList = cardlist.OrderBy(c => Guid.NewGuid()).ToList();

		//	foreach (var item in cardlist)
		//		Console.WriteLine(item.ValueIndex + " " + item.Suit + " " + item.Color);
		//}























	}
}
