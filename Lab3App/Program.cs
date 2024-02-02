using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionBoard board = new CollectionBoard();

            List<Collectable> possibleCollectiable = new List<Collectable>();

            possibleCollectiable.Add(new Coin("Nickel", score: 20, value: 5));
            possibleCollectiable.Add(new Coin("Dime", score: 40, value: 10));
            possibleCollectiable.Add(new Coin("Toony", score: 50, value: 100));

            for (int i = 1; i <= 5; i++)
            {
                possibleCollectiable.Add(new Diamond("Diamond" + i, score: 100));
            }

            possibleCollectiable.Add(new Axe("OnlyAxe"));

            possibleCollectiable.Add(new MagicWand("OnlyMagicWand"));


            foreach (Collectable collectable in possibleCollectiable)
            {
                collectable.Board = board;
            }

            List<Collectable> collected = new List<Collectable>();

            foreach (Collectable collectable in possibleCollectiable)
            {
                collectable.AddMe(collected);
            }

            Console.WriteLine("========================================");
            Console.WriteLine("==== All the Collected items ===========");
            Console.WriteLine("========================================");

            foreach (Collectable collectable in possibleCollectiable)
            {
                collectable.Display();
            }
        }
    }
}
