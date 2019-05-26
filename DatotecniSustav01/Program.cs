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
            //maksimalno vrijeme kreiranja(duljina stringa)
            int kreiranjemax = 0;
            string kreiranje;
            //maksimalno vrijeme zadnjeg pristupa(duljina stringa)
            int zadnjemax = 0;
            string zadnje;

            
            foreach (DirectoryInfo d in direktoriji)
            {
                //pomocu foreach trazimo najdulji naziv i spremamo ga u nazivmax
                if (d.FullName.Length > nazivmax)
                {
                    nazivmax = d.FullName.Length;
                }

                //pomocu foreach trazimo najdulji string kreiranja
                kreiranje = d.CreationTime.ToString();
                if (kreiranje.Length > kreiranjemax)
                {
                    kreiranjemax = kreiranje.Length;
                }

                //pomocu foreach trazimo najdulji string zadnjeg pristupa
                zadnje = d.LastAccessTime.ToString();
                if (zadnje.Length > zadnjemax)
                {
                    zadnjemax = zadnje.Length;
                }
            }

            //pomocu PadRight metode kreiramo fleksibilnu širinu tablice prema kreiranjemax, zadnjemax, nazivmax
            Console.Write("-".PadRight(kreiranjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(zadnjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");

            Console.Write("Vrijeme kreiranja".PadRight(kreiranjemax)); Console.Write("+");
            Console.Write("Zadnji pristup".PadRight(zadnjemax)); Console.Write("+");
            Console.Write("Naziv".PadRight(nazivmax)); Console.WriteLine("+");

            Console.Write("-".PadRight(kreiranjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(zadnjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");

            foreach (DirectoryInfo d in direktoriji)
            {
                Console.Write("{0}".PadRight((kreiranjemax+ 3) - d.CreationTime.ToString().Length), d.CreationTime); Console.Write("|");
                Console.Write("{0}".PadRight((zadnjemax + 3) - d.LastAccessTime.ToString().Length), d.LastAccessTime); Console.Write("|");
                Console.Write("{0}".PadRight((nazivmax+ 3) - d.FullName.Length), d.FullName); Console.WriteLine("|");
            }

            Console.Write("-".PadRight(kreiranjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(zadnjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");

        }

        public static void DirektoriD() {

            string put = @"D:\";
            var direktoriji = new DirectoryInfo(put).GetDirectories();

            //maksimalni naziv
            int nazivmax = 0;
            //maksimalno vrijeme kreiranja(duljina stringa)
            int kreiranjemax = 0;
            string kreiranje;
            //maksimalno vrijeme zadnjeg pristupa(duljina stringa)
            int zadnjemax = 0;
            string zadnje;


            foreach (DirectoryInfo d in direktoriji)
            {
                //pomocu foreach trazimo najdulji naziv i spremamo ga u nazivmax
                if (d.FullName.Length > nazivmax)
                {
                    nazivmax = d.FullName.Length;
                }

                //pomocu foreach trazimo najdulji string kreiranja
                kreiranje = d.CreationTime.ToString();
                if (kreiranje.Length > kreiranjemax)
                {
                    kreiranjemax = kreiranje.Length;
                }

                //pomocu foreach trazimo najdulji string zadnjeg pristupa
                zadnje = d.LastAccessTime.ToString();
                if (zadnje.Length > zadnjemax)
                {
                    zadnjemax = zadnje.Length;
                }
            }

            //pomocu PadRight metode kreiramo fleksibilnu širinu tablice prema kreiranjemax, zadnjemax, nazivmax
            Console.Write("-".PadRight(kreiranjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(zadnjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");

            Console.Write("Vrijeme kreiranja".PadRight(kreiranjemax)); Console.Write("+");
            Console.Write("Zadnji pristup".PadRight(zadnjemax)); Console.Write("+");
            Console.Write("Naziv".PadRight(nazivmax)); Console.WriteLine("+");

            Console.Write("-".PadRight(kreiranjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(zadnjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");

            foreach (DirectoryInfo d in direktoriji)
            {
                Console.Write("{0}".PadRight((kreiranjemax + 3) - d.CreationTime.ToString().Length), d.CreationTime); Console.Write("|");
                Console.Write("{0}".PadRight((zadnjemax + 3) - d.LastAccessTime.ToString().Length), d.LastAccessTime); Console.Write("|");
                Console.Write("{0}".PadRight((nazivmax + 3) - d.FullName.Length), d.FullName); Console.WriteLine("|");
            }

            Console.Write("-".PadRight(kreiranjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(zadnjemax, '-')); Console.Write("+");
            Console.Write("-".PadRight(nazivmax, '-')); Console.WriteLine("+");
        }

        public static void DatotekeC()
        {
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
            
            int broj = 0;
            do
            {
                Console.WriteLine("Izbornik za ispis");
                Console.WriteLine("<----------------------------->");
                Console.WriteLine("--->   Direktori C ---> 1");
                Console.WriteLine("--->   Direktori D ---> 2");
                Console.WriteLine("--->   Datoteke C ---> 3");
                Console.WriteLine("--->   Datoteke D ---> 4");
                Console.WriteLine("--->   Logicki diskovi ---> 5");
                Console.WriteLine("--->   Sve o C particiji ---> 6");
                Console.WriteLine("--->   Sve od D particiji---> 7");
                Console.WriteLine("<----------------------------->");
                Console.WriteLine("Ako necete ništa upisati ili točno brojku sve navedeno u izborniku će vam se ispisati!");
                Console.WriteLine();
                Console.Write("Upisite broj koji zelite pretraziti ---> ");
                string meni = Console.ReadLine();
                if (meni == "1")
                {
                    Console.WriteLine("--->   Direktori C");
                    DirektoriC();
                }
                else if (meni == "2")
                {
                    Console.WriteLine("--->   Direktori D");
                    DirektoriD();
                }
                else if (meni == "3")
                {
                    Console.WriteLine("--->   Datoteke C");
                    DatotekeC();
                }
                else if (meni == "4")
                {
                    Console.WriteLine("--->   Datoteke D");
                    DatotekeD();
                }
                else if (meni == "5")
                {
                    Console.WriteLine("--->   Logicki diskovi");
                    LogickiDiskovi();
                }
                else if (meni == "6")
                {
                    Console.WriteLine("--->   Sve o C particiji");
                    Console.WriteLine("--->   Direktori C");
                    DirektoriC();
                    Console.WriteLine("--->   Datoteke C");
                    DatotekeC();
                }
                else if (meni == "7")
                {
                    Console.WriteLine("--->   Sve o D particiji");
                    Console.WriteLine("--->   Direktori D");
                    DirektoriD();
                    Console.WriteLine("--->   Datoteke D");
                    DatotekeD();
                }
                else
                {
                    Console.WriteLine("--->   Sve o C particiji");
                    Console.WriteLine("--->   Direktori C");
                    DirektoriC();
                    Console.WriteLine("--->   Datoteke C");
                    DatotekeC();
                    Console.WriteLine("--->   Sve o D particiji");
                    Console.WriteLine("--->   Direktori D");
                    DirektoriD();
                    Console.WriteLine("--->   Datoteke D");
                    DatotekeD();
                    Console.WriteLine("--->   Logicki diskovi");
                    LogickiDiskovi();
                }

                Console.WriteLine("");
                Console.Write("Dali želite ponovo birati neki od ispisa? DA/NE   --->   ");
                string odgovor = Console.ReadLine();
                if (odgovor.ToUpper() == "DA")
                {
                    broj = 0;
                }

                else
                {
                    broj = 1;
                }

            } while (broj == 0);
                
        } 
    }
}
