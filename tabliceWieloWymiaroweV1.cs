using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabliceWielowymiaroweV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witaj w programie monitorującym częstotliwość brania leków przeciwbólowych.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Pacjencie, po operacji jaką zastosowano w twoim leczeniu możesz przyjmować leki przeciwbóleowe o dwóch godzinach:");

            Console.WriteLine(" 8.00  i  18.00");
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Teraz wprowadzimy liczbę przyjętych tabletek przeciwbólowych w ostatnim tygodniu");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
           
            int[,] tabletki = new int[7, 2];


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w poniedizałek o 8.00"); // wiaodomo, można to dopracować używając funkcji 
            tabletki[0, 0] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w poniedizałek o 18.00"); 
            tabletki[0, 1] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek wtorek o 8.00"); 
            tabletki[1, 0] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w wtorek o 18.00"); 
            tabletki[1, 1] = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w środę  o 8.00");
            tabletki[2, 0] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w środę o 18.00");
            tabletki[2, 1] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w czwartek  o 8.00");
            tabletki[3, 0] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w czwartek o 18.00");
            tabletki[3, 1] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w piątek  o 8.00");
            tabletki[4, 0] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w piątek o 18.00");
            tabletki[4, 1] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w sobotę  o 8.00");
            tabletki[5, 0] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w sobotę o 18.00");
            tabletki[5, 1] = int.Parse(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w niedzielę  o 8.00");
            tabletki[6, 0] = int.Parse(Console.ReadLine());
            Console.Clear();



            Console.WriteLine("wprowadz liczbe zjedzonych tabletek w niedzielę  o 18.00");
            tabletki[6, 1] = int.Parse(Console.ReadLine());
            Console.Clear();

                for (int j = 0; j<tabletki.GetLength(0); j++)
                {
                    for(int k = 0; k<tabletki.GetLength(1); k++)
                    {
                        Console.Write(tabletki[j,k] + " ");

                    }
                    Console.WriteLine();
                }
            Console.ReadLine();
            
            //w przyszłości rozbuduj o przykładowo: średnią przyjętych dawek, sumę itp itd...

        }
    }
}
