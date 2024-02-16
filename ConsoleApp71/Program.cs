using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedengirilenyazililarinveperformansinort
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen öğrenci adını giriniz");
            string ad = Console.ReadLine();

            Console.WriteLine("Lütfen 1. yazılı notunuzu giriniz");
            int yazili1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. yazılı notunuzu giriniz");
            int yazili2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 1. Performans notunuzu giriniz");
            int performans1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Performans notunuzu giriniz");
            int performans2 = Int32.Parse(Console.ReadLine());

            double ortalama = (yazili1 + yazili2 + performans1 + performans2) / 4;

            Console.WriteLine("{0} adlı öğrencinin yazılı ve performans ortalaması {1}", ad, ortalama);
            Console.ReadLine();

        }
    }
}