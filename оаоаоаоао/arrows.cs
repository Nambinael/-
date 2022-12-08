using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace оаоаоаоао
{
    internal class arrows
    {
       int i = 0;
       private void ClearArrowPlace(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("  ");
            }
        }
        public int mefedron(int min, int max)
        {
            i = 0;
            Console.SetCursorPosition(0, i);
            ConsoleKeyInfo key = Console.ReadKey();
            while ((key.Key != ConsoleKey.Enter) && (key.Key != ConsoleKey.Escape))
            {
                ClearArrowPlace(0, max);
                Console.SetCursorPosition(0, i);
                Console.WriteLine("->");
                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    i--;
                    if (i == min)
                        i = 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    i++;
                    if (i == max)
                        i = 0;
                }

            }
            if (key.Key == ConsoleKey.Escape)
            {
                return -1;
            }
            else
            {
                return i;
            }
                
        }
    }
}
