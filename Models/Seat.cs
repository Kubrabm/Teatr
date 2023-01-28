using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatr.Models
{
    public class Seat : Entity
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                        Premium Hall");
            Console.WriteLine();
            Console.WriteLine("                                   Please choose your seat");
            Console.WriteLine();

            int rowCount = 0;
            int[,] Seats = new int[10, 12];

            for (int i = 0; i < 1; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 1; i < 2; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 2; i < 3; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 3; i < 4; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 4; i < 5; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 5; i < 6; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 6; i < 7; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 7; i < 8; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 8; i < 9; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 9; i < 10; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 10; i < 11; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            for (int i = 11; i < 12; i++)
            {
                Console.Write($"{i + 1,7}");
            }
            Console.WriteLine();
            Console.Write($"   |------|------|------|------|------|------|------|------|------|------|------|------|");
            ////for (int i = 1; i < 12; i++)
            ////{
            ////    Console.Write($"{i + 1,6}");
            ////}
            Console.WriteLine();
            for (int row = 0; row < Seats.GetLength(0); row++)
            {
                Console.Write($"{row + 1,-3}|");
                for (int column = 0; column < Seats.GetLength(1); column++)
                {
                    Console.Write("Empty |");
                }
                Console.WriteLine();
                Console.WriteLine($"   |------|------|------|------|------|------|------|------|------|------|------|------|");
            }

            Console.Write($"c: ");
            int choicerow = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"Enter the column of the row of your choice: ");
            int choiceolumn = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

    }
}
