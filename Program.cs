using System;

namespace myApp
{
   class Program
   {
      static void Main(string[] args)
      {
         Card card = new Card();
         var cards = card.ShuffledCards;
         Console.WriteLine("Cards after shuffle..");
         foreach (var c in cards)
         {
            Console.WriteLine(c);
         }
         Console.ReadLine();
      }
   }
}
