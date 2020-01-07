using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace CardGame
{
	class DataAccess
	{

		public List<HighScore> GetHighScores()
		{
			using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnString("CardGame"));
			return connection.Query<HighScore>("select * from HighScore").AsList();
		}

		public HighScore GetSingleHighScore()
		{
			using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnString("CardGame"));
			return connection.QueryFirst<HighScore>("select * from HighScore");
		}


		public void SetNewPlayer(string name)
		{
			using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnString("CardGame"));
			connection.Query<HighScore>($"insert into HighScore (Player, Score)values('{name}', 0)");
			//connection.BeginTransaction();
			
		}

		public List<HighScore> ShowPlayers()
		{
			using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnString("CardGame"));
			return connection.Query<HighScore>($"select H.Id, H.player ,H.Score from HighScore as H").AsList();
		}

		public HighScore SelectedPlayer(int id)
		{
			using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnString("CardGame"));
			var currentPlayer = connection.QueryFirst<HighScore>($"select H.player, H.Score from HighScore as H where H.Id = {id}");
			return currentPlayer;

			//return connection.QueryFirst<HighScore>($"select H.player from HighScore as H where H.Id = {id}");
			//return connection.Query<HighScore>($"select H.player from HighScore as H where H.Id = {id}");
		}
		public HighScore SelectedPlayer(string playerName)
		{
			using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnString("CardGame"));
			var currentPlayer = connection.QueryFirst<HighScore>($"select H.player, H.Score from HighScore as H where H.player = '{playerName}'");
			return currentPlayer;

			//return connection.QueryFirst<HighScore>($"select H.player from HighScore as H where H.Id = {id}");
			//return connection.Query<HighScore>($"select H.player from HighScore as H where H.Id = {id}");
		}

		public void UpdateHighScore(string playerName, int playerHighScore)
		{

			using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnString("CardGame"));
			connection.Query<HighScore>($"update Highscore set Score = Score + {playerHighScore} where highscore.Player like '{playerName}'");



		}



	}
}