using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BingoGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.Combine("C:\\Temp", "nomes.txt");
            var lines = File.ReadLines(path, Encoding.UTF8).ToList();


            var cardsCount = 30;
            var wordsByCardsCount = 20;

            
            var rnd = new Random();
            
            var cards = new List<string>();
            
            for (var i = 1; i <= cardsCount; i++)
            {
                var card = lines.OrderBy(x => rnd.Next()).Take(wordsByCardsCount).ToArray();
                cards.Add(i + ". " + string.Join(", ", card));
            }

            cards = cards.Distinct().ToList();

            foreach (var card in cards)
            {
                Console.WriteLine(card); 
            }
        }
    }
}
