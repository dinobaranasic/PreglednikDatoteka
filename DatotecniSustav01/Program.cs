using System;
using System.IO;

namespace DatotecniSustav01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("C: 1");
            Console.WriteLine("D: 2");
            Console.WriteLine("Upišite broj pokraj particije za koju particiju želite prikazati direktorije: ");
            string broj;
            broj = Console.ReadLine();

            try
            {
                if (broj == "1")
                {
                    string put = @"C:";
                    var direktoriji = new DirectoryInfo(put).GetDirectories();
                    foreach (DirectoryInfo dir in direktoriji)
                    {
                        Console.WriteLine(dir);
                    }

                }

                else if (broj == "2")
                {
                    string put = @"D:";
                    var direktoriji = new DirectoryInfo(put).GetDirectories();
                    foreach (DirectoryInfo dir in direktoriji)
                    {
                        Console.WriteLine(dir);
                    }
                }

                else
                {
                    Console.WriteLine("Upisali ste krivi broj pokraj particije koju želite pretražiti!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Pogreška: {0}", e.ToString());
            }
        }
            // Console.SetCursorPosition(0, brojRedova);
         //Main
    }
}
