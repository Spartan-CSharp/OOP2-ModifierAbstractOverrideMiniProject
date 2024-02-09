using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardGameLibrary.Enums;

namespace CardGameLibrary.Models
{
	public class PlayingCardModel
	{
		public CARDSUIT Suit
		{
			get; set;
		}

		public CARDVALUE Value
		{
			get; set;
		}

		public PlayingCardModel()
		{
		}

		public PlayingCardModel(CARDSUIT cardSuit, CARDVALUE cardValue)
		{
			Suit = cardSuit;
			Value = cardValue;
		}
	}
}
