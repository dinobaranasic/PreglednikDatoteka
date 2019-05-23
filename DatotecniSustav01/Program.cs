using System;
using System.IO;

namespace DatotecniSustav01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C:");
            string direktorij = @"C:\";
            DirectoryInfo dirInfo = new DirectoryInfo(direktorij);
            var datoteke = dirInfo.GetFiles();

            float velicina = 0;
            //maksimalni naziv
            int nazivmax = 0;
            
            //pomocu foreach trazimo najdulji naziv i spremamo ga u nazivmax
            foreach (FileInfo d in datoteke)
            {
                if (d.FullName.Length > nazivmax)
                {
                    nazivmax = d.FullName.Length;
                }
            }

            //pomocu PadRight metode kreiramo fleksibilnu širinu tablice prema nazivmax
            Console.Write("+------------------+-------------+---------+--------+------+"); Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");
            Console.Write("| B                |          KB |      MB |     GB |   TB |"); Console.Write("Naziv datoteka".PadRight(nazivmax)); Console.WriteLine("+");
            Console.Write("+------------------+-------------+---------+--------+------+"); Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");

            foreach (FileInfo d in datoteke)
            {
                velicina += d.Length;
                Console.Write("|{0, 15} B | {1, 8} KB | {2, 4} MB | {3, 3} GB | {4, 1} TB |",
                    d.Length,
                    d.Length / 1024,
                    d.Length / (1024 * 1024),
                    d.Length / (1024 * 1024 * 1024),
                    (d.Length / (1024 * 1024 * 1024)) / 1024);
                    Console.Write("{0}".PadRight((nazivmax + 3) - d.FullName.Length), d.FullName); Console.WriteLine("|");
            }

            Console.Write("+------------------+-------------+---------+--------+------+"); Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");
            Console.Write("|{0, 15} B | {1, 8} KB | {2, 4} MB | {3, 3} GB | {4, 1} TB |",
                velicina,
                velicina / 1024,
                //zaokružujemo vrijednosti da bi nam stale unutar tablice
                Math.Round(velicina / (1024 * 1024)),
                Math.Round(velicina / (1024 * 1024 * 1024)),
                Math.Round((velicina / (1024 * 1024 * 1024)) / (1024)));

            Console.WriteLine();
            Console.Write("+------------------+-------------+---------+--------+------+"); Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");

            Console.SetCursorPosition(1, 3);
            Console.Write(">");
            int brojRedova = datoteke.Length + 6;

            int cekanjeTreperenje = 500;
            Console.CursorVisible = false;
            int pokazivacY = 3;
            while (true)
            {
                System.Threading.Thread.Sleep(cekanjeTreperenje);
                Console.SetCursorPosition(1, pokazivacY);
                Console.Write(" ");
                System.Threading.Thread.Sleep(cekanjeTreperenje);
                Console.SetCursorPosition(1, pokazivacY);
                Console.Write(">");

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pritisnutaTipka = Console.ReadKey(true);
                    if (pritisnutaTipka.Key == ConsoleKey.DownArrow)
                    {
                        pokazivacY++;
                    }
                }
            }

            // Console.SetCursorPosition(0, brojRedova);
        } //Main
    }
}
