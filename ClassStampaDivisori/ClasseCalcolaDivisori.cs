using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStampaDivisori
{
    public class ClasseCalcolaDivisori
    {
        public static int LeggiNum()
        {
            Console.Write("Inserisci un numero: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public static void StampaDivisori(int n)
        {
            int MAX = n / 2;
            int i = 1;
            if (n > 0)
            {
                while (i <= MAX)
                {
                    if (n % i == 0)
                        Console.WriteLine($"Il numero {i} è un divisore di {n}");
                    i++;
                }
                Console.WriteLine($"Il numero {n} è un divisore di {n}");
            }
            else
            {
                Console.WriteLine("Il numero inserito non è valido.");
            }
        }
    }
}
