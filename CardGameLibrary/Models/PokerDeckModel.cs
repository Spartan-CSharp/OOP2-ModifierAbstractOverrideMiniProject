using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameLibrary.Models
{
	public class PokerDeckModel : DeckModel
	{
		public PokerDeckModel()
		{
			CreateDeck();
			ShuffleDeck();
		}

		public List<PlayingCardModel> ExchangeCards(List<PlayingCardModel> cardsToDiscard)
		{
			List<PlayingCardModel> output = new List<PlayingCardModel>();

			foreach ( PlayingCardModel card in cardsToDiscard )
			{
				output.Add(DrawOneCard());
				_discardPile.Add(card);
			}

			return output;
		}

		public override List<PlayingCardModel> DealCards()
		{
			List<PlayingCardModel> output = new List<PlayingCardModel>();

			for ( int i = 0; i < 5; i++ )
			{
				output.Add(DrawOneCard());
			}

			return output;
		}
	}
}
