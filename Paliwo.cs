using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace kalkulatorPaliwa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie, który pomoże Ci obliczyć zużycie paliwa twojego pojazdu spalinowgo");
            Console.WriteLine("Podaj rodzaj używanego Paliwa : diesel / benzyna / lpg ");
            string a = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("wybrane przez Ciebie paliwo to :" + a);
            Console.ForegroundColor= ConsoleColor.White;

            Console.WriteLine("Wprowadź przejechany dystans:");
            double dystans = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź ilość zużytego paliwa :");
            double zuzycie = double.Parse(Console.ReadLine());

            double spalanie = (zuzycie / dystans) * 100;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Średnie spanie twojego pojazdu na wskazanym dystansie to : " + String.Format("{0:N2}", spalanie));

            Console.ReadLine();
        }
    }
}