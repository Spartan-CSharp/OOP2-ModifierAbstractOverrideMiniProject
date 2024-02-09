using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardGameLibrary.Enums;

namespace CardGameLibrary.Models
{
	public abstract class DeckModel
	{
		internal List<PlayingCardModel> _fullDeck = new List<PlayingCardModel>();
		internal List<PlayingCardModel> _drawPile = new List<PlayingCardModel>();
		internal List<PlayingCardModel> _discardPile = new List<PlayingCardModel>();

		public void ShuffleDeck()
		{
			Random rnd = new Random();
			_drawPile = _fullDeck.OrderBy(x => rnd.Next()).ToList();
		}

		public abstract List<PlayingCardModel> DealCards();

		protected PlayingCardModel DrawOneCard()
		{
			PlayingCardModel output = _drawPile.First();
			_ = _drawPile.Remove(output);
			return output;
		}

		private protected void CreateDeck()
		{
			_fullDeck.Clear();

			for ( int suit = 0; suit < 4; suit++ )
			{
				for ( int value = 0; value < 13; value++ )
				{
					PlayingCardModel card = new PlayingCardModel((CARDSUIT)suit, (CARDVALUE)value);
					_fullDeck.Add(card);
				}
			}
		}
	}
}
