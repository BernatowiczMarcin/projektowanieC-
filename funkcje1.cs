using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcjestatyczne
{
    class Program
    {
        static void Main(string[] args) 
                                        
        {
            Console.WriteLine("Wprowadz pierwszą liczbę: " );
                int a = int.Parse( Console.ReadLine() );

            Console.WriteLine("Wprowadz drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(" Po dodaniu wprowadzonych libcz otrzymasz Wartość: ");
               mat1(a,b);
            Console.ReadLine();

            Console.WriteLine(" Po odjejmowaniu wprowadzonych libcz otrzymasz Wartość: ");
            mat2(a, b);
            Console.ReadLine();

            Console.WriteLine(" Irolaz wprowadzonych libcz wynosi: ");
            mat3(a, b);
            Console.ReadLine();

            Console.WriteLine(" W trym momencie wyswietlę dla Ciebie prostokąt o wymiarach wproawdzonych wcześniej! ");
            Console.WriteLine(" ");
            figura(a,b);

        }

        static void mat1(int x, int y)
        {
            int wynik = x + y;
            Console.WriteLine( wynik);

        }
        static void mat2(int x, int y)
        {
            int wynik = x - y;
            Console.WriteLine(wynik);

        }

        static void mat3(int x, int y)
        {
            int wynik = x * y;
            Console.WriteLine(wynik);

        }

        static void figura( int x, int y)
        {
            for( int i= 0; i < x; i++)
            {
                Console.Write("*");
                for (int j = 0; j < y; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }


    }
}
