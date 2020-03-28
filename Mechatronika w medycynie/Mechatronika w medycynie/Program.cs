using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechatronika_w_medycynie
{
    class Program
    {
        static void Main(string[] args)
        {
            const string plik1 = "C:\\Users\\Dell\\Downloads\\Collection2.xlsx";
            const string plik2 = "C:\\Users\\Dell\\Downloads\\Collection5.xlsx";
            const string plik3 = "C:\\Users\\Dell\\Downloads\\Collection10.xlsx";

            Kolekcja kolekcja1 = new Kolekcja();
            Kolekcja kolekcja2 = new Kolekcja();
            Kolekcja kolekcja3 = new Kolekcja();

            Console.WriteLine("start");
            wczytaj(plik1, ref kolekcja1);
            Console.WriteLine("1 kolekcja");
            wczytaj(plik2, ref kolekcja2);
            Console.WriteLine("2 kolekcja");
            wczytaj(plik3, ref kolekcja3);
            Console.WriteLine("3 kolekcja");
        }

        static void wczytaj(string plik, ref Kolekcja kolekcja)
        {
            Excel excel = new Excel(plik, 1);

            for (int i = 8; i < 400; i++)
            {
                WierszKolekcji wierszKolekcji = new WierszKolekcji();

                wierszKolekcji.time = excel.ReadCell(i, 3);
                wierszKolekcji.x1 = excel.ReadCell(i, 5);
                wierszKolekcji.y1 = excel.ReadCell(i, 6);
                wierszKolekcji.z1 = excel.ReadCell(i, 7);
                wierszKolekcji.x2 = excel.ReadCell(i, 9);
                wierszKolekcji.y2 = excel.ReadCell(i, 10);
                wierszKolekcji.z2 = excel.ReadCell(i, 11);

                kolekcja.kolekcja.Add(wierszKolekcji);
            }

        }
    }
    
}
