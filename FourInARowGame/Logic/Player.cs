using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame
{
	public class Player : IPlayer
	{
		public string playerName { get; set; }
		public string choosedDiscColor { get; set; }
		public int availableDiscCount { get; set; }
		public bool firstPlayer { get; set; }

		public string GetDiscColor()
		{
			DiscColorChooser();

			return choosedDiscColor;
		}

		public void DiscColorChooser()
		{
		   AIHelper aIHelper = new AIHelper();
		   choosedDiscColor = aIHelper.DiscColorChooser();
		}

		public string GetPlayerName()
		{
			UIContent content = new UIContent();
			
			content.InitializeGetPlayerName();
			playerName = Console.ReadLine();

			return playerName;
		}

		public int GetAvailableDiscCount()
		{
			AIHelper aIHelper = new AIHelper();
			availableDiscCount = aIHelper.SetDiscCount();

			return availableDiscCount;
		}

		public bool GetFristPlayerOption()
		{
			AIHelper aIHelper = new AIHelper();
			firstPlayer = aIHelper.SetFirstPlayer();

			return firstPlayer;
		}
	}
}
