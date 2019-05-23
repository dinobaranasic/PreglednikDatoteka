using System;
using System.IO;

namespace DatotecniSustav01
{
    class Program
    {
        public static void DirektoriC()
        {
            
            string put = @"C:\";
            var direktoriji = new DirectoryInfo(put).GetDirectories();

            //maksimalni naziv
            int nazivmax = 0;
            int vrijememax = 0;
            string vrijeme;
            //pomocu foreach trazimo najdulji naziv i spremamo ga u nazivmax
            foreach (DirectoryInfo d in direktoriji)
            {
                if (d.FullName.Length > nazivmax)
                {
                    nazivmax = d.FullName.Length;
                }
                vrijeme = d.CreationTime.ToString();
                if (vrijeme.Length > vrijememax)
                {
                    vrijememax = vrijeme.Length;
                }
                
            }

            Console.WriteLine("naj vrijeme {0} {1}", vrijememax, nazivmax);
            //pomocu PadRight metode kreiramo fleksibilnu širinu tablice prema nazivmax
            Console.Write("+---------------------+---------------------------+"); Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");
            Console.Write("| Vrijeme kreiranja   | Zadnje vrijeme pristupa   |"); Console.Write("Naziv direktorija".PadRight(nazivmax)); Console.WriteLine("+");
            Console.Write("+---------------------+---------------------------+"); Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");

            foreach (DirectoryInfo d in direktoriji)
            {
                Console.Write(" {0, 1} | {1, 1} |",
                    d.CreationTime,
                    d.LastAccessTime);
                Console.Write("{0}".PadRight((nazivmax + 3) - d.FullName.Length), d.FullName); Console.WriteLine("|");
            }

            /*Console.Write("+------------------+-------------+---------+--------+------+"); Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");
            Console.Write("|{0, 15} B | {1, 8} KB | {2, 4} MB | {3, 3} GB | {4, 1} TB |",
                velicina,
                velicina / 1024,
                //zaokružujemo vrijednosti da bi nam stale unutar tablice
                Math.Round(velicina / (1024 * 1024)),
                Math.Round(velicina / (1024 * 1024 * 1024)),
                Math.Round((velicina / (1024 * 1024 * 1024)) / (1024)));

            Console.WriteLine();
            Console.Write("+------------------+-------------+---------+--------+------+"); Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");
            */

        }

        public static void DatotekeC()
        {
            Console.WriteLine("Ispis datoteka na C disku:");
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
        }
        public static void DatotekeD()
        {
            Console.WriteLine("Ispis datoteka na D disku:");
            string direktorij = @"D:\";
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
        }

        public static void LogickiDiskovi() {
            
            //Dohvat svih logickih diskova
            DriveInfo[] drives = DriveInfo.GetDrives();
            int najveceIme = 0;
            foreach (DriveInfo d in drives)
            {
                if (d.IsReady)
                {
                    if (d.VolumeLabel.Length > najveceIme)
                    {
                        najveceIme = d.VolumeLabel.Length;
                    }

                }
            }

            Console.Write("+------------------+---------------+---------+-----------+"); Console.Write("-".PadRight(najveceIme, '-')); Console.WriteLine("+");
            Console.Write("| Oznaka diska     |Ukupna veličina|Slobodno |     %     |"); Console.Write("Naziv Diska".PadRight(najveceIme)); Console.WriteLine("+");
            Console.Write("+------------------+---------------+---------+-----------+"); Console.Write("-".PadRight(najveceIme, '-')); Console.WriteLine("+");
            foreach (DriveInfo d in drives)
            {

                if (d.IsReady)
                {

                    Console.Write("|{0, 16}  | {1, 10} GB | {2, 4} GB | {3, 7} % |",
                    d.Name,
                    d.TotalSize / (1024 * 1024 * 1024),
                    d.TotalFreeSpace / (1024 * 1024 * 1024),
                    Math.Round(((double)d.TotalFreeSpace / (double)d.TotalSize) * 100, 2));
                    Console.Write("{0}".PadRight((najveceIme + 3) - d.VolumeLabel.Length), d.VolumeLabel); Console.WriteLine("|");
                }
                else
                {
                    Console.Write("|{0, 16}  | {1, 12}  | {2, 6}  | {3, 8}  |", d.Name, "n/a", "n/a", "n/a");
                    Console.Write("n/a".PadRight((najveceIme))); Console.WriteLine("|");
                }
            }
            Console.Write("+------------------+---------------+---------+-----------+"); Console.Write("-".PadRight((najveceIme), '-')); Console.WriteLine("+");

        }

        static void Main(string[] args)
        {
            DirektoriC();
            
        } 
    }
}
