using System;

namespace Funkcje
{


    public class Program

    {              
        public static void Main(string[] args)
        {
            Console.WriteLine("Dokonam oblicznen figury geometrycznej");
            Console.WriteLine("wprowadz dlugos (w metrach) boku a figury :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("wprowadz dlugos boku (w metrach) b figury :");
            int b = int.Parse(Console.ReadLine());


            int wynik1 = Funkcja1(a, b);
            Console.WriteLine("Pole figury wynosi :" +wynik1);

            Console.WriteLine("Wprowadz wysokosc figury(w metrach), aby obliczyc jej objetosc");
            int c = int.Parse(Console.ReadLine());
            int wynik2 = Funkcja2(wynik1, c);
            Console.WriteLine("Objetosc figury wynosi : " + wynik2);

            Console.WriteLine("Wprowadz ilosc plynu (w litrach) do wypelnienia ");
            int plyn = int.Parse(Console.ReadLine());
            int wynik3 = Funkcja3(wynik2, plyn);
            Console.WriteLine("do bryly mozesz wlac nastepujacą ilość płynu : {0}, pozostalo miejsca na {1} litrow",wynik2 , wynik3);
        }
        static int Funkcja1(int a,int b)
        {
            return a * b;
        }
        static int Funkcja2(int pole,int h)
        {
            return pole * h;
        }
        static int Funkcja3(int okon, int oko)
        {
            if(okon-oko <= 0)
            {
                Console.WriteLine("Ilosc plynu jest za duza !");
                return 0;
            }
            return okon - oko;
        }

    }  
}