using ChessSolutions.DataResolver.Models;
using System;

namespace BishopMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check if bishop captures target
            //Solution
            //x1-x2 = n1; y1-y2 = n2 |n1| == |n2|;

            var bishop = new BoardSquareModel();
            

            Console.WriteLine("Print coordinates of bishop:");
            Console.Write("X: ");
            bishop.X = Int32.Parse(Console.ReadLine());
            Console.Write("Y: ");
            bishop.Y  = Int32.Parse(Console.ReadLine());

            var target = new BoardSquareModel();
            Console.WriteLine("Print coordinates of target:");
            Console.Write("X: ");
            target.X = Int32.Parse(Console.ReadLine());
            Console.Write("Y: ");
            target.Y = Int32.Parse(Console.ReadLine());

            if (Math.Abs(target.X - bishop.X) == Math.Abs(target.Y - bishop.Y))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
