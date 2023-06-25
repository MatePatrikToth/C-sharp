using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._30C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int db;

            do
            {
                Console.Write("Kerem a butorok darabszamat: ");
                db = Convert.ToInt32(Console.ReadLine());
            }
            while (db < 1);

            int[] arak = new int[db];
            string[] cikkszamok = new string[db];

            for (int i = 0; i < db; i++)
            {
                do
                {
                    Console.WriteLine($"Kerem a(z) {i + 1}. cikkszamot: ");
                    cikkszamok[i] = Console.ReadLine();
                }
                while (String.IsNullOrWhiteSpace(cikkszamok[i]) == true);

                do
                {
                    Console.Write($"Kerem a(z) {cikkszamok[i]} cikkszamu butor arat: ");
                    arak[i] = Convert.ToInt32(Console.ReadLine());
                }
                while (arak[i] <= 0);
            }

            int a = 0;

            while (a < db && !(arak[0] >= 30000 && arak[a] <= 50000))
            {
                a++;
            }

            if (a < db)
            {
                Console.WriteLine("Volt olyan butor aminek az ra 30000 es 50000 koze esett.");
            }

            else
            {
                Console.WriteLine("Nem volt olyan butor aminek az ra 30000 es 50000 koze esett.");
            }

            Console.ReadKey();
        }
    }
}
