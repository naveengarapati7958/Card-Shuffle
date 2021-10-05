using System;
using System.Collections;

namespace myApp
{
   class Card
   {
      string[] _suits = { "Spades", "Diamonds", "Clubs", "Hearts" };
      string[] _values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
      ArrayList _initialCards = new ArrayList();

      #region Constructors

      /// <summary>
      /// Initializes the 52 cards
      /// </summary>
      public Card()
      {
         for (int i = 0; i < _suits.Length; i++)
         {
            for (int x = 0; x < _values.Length; x++)
            {
               _initialCards.Add($"{_values[x]} Of { _suits[i]}");
            }
         }

         // shuffles the cards
         Shuffle();
      }

      #endregion

      #region Helpers

      /// <summary>
      /// It shuffles the cards
      /// </summary>
      void Shuffle()
      {
         Random random = new Random();
         for (int i = 0; i < _initialCards.Count; i++)
         {
            int randomCard = random.Next(52);
            string tempCard = _initialCards[randomCard].ToString();
            _initialCards[randomCard] = _initialCards[i];
            _initialCards[i] = tempCard;
         }
      }

      #endregion

      #region Properties
     
      // Returns the shuffled cards
      public ArrayList ShuffledCards
      {
         get
         {
            return _initialCards;
         }
      }

      #endregion
   }
}
