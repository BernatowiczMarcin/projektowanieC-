using System;

namespace Funkcje
{


    public class Program

    {               // definiowniowane metod 


        /* public static void Main(string[] args)
         {
             Console.Write(" Wprowadz wartosc wymiaru A :");
             int wymiarA = int.Parse(Console.ReadLine());
             Console.Write(" Wprowadz wartosc wymiaru B :");
             int wymiarB = int.Parse(Console.ReadLine());
             Console.Write(" Wprowadz wartosc wymiaru C :");
             int wymiarC = int.Parse(Console.ReadLine());

             int wynik = ObliczeniePola(wymiarA, wymiarB, wymiarC);
             Console.WriteLine("Pole wynosi : " + wynik);
             int wynik1 = ObliczeniePola(wynik, wymiarC);
             Console.WriteLine("Objetosc wynosi : " + wynik1);


             int h = 17;
             int wynik2 = ObliczeniePojemnosci(wynik1,h);
             Console.WriteLine(wynik2);
         } 

         static int ObliczeniePola(int a, int b, int c)
         {

             return  a * b * c;

         }
         static int ObliczeniePola(int pole, int h)
         {
             return pole * h;
         }


         static int ObliczeniePojemnosci(int pole, int h)
         {
             return pole * h;
         }
        */
        public static void Main(string[] args)
        {
            Console.WriteLine("wprowadz dlugos boku figury :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("wprowadz dlugos boku figury :");
            int b = int.Parse(Console.ReadLine());


            int wynik1 = Funkcja1(a, b);
            Console.WriteLine("Pole figury wynosi :" +wynik1);

            Console.WriteLine("Wprowadz wysokosc figury ");
            int c = int.Parse(Console.ReadLine());
            int wynik2 = Funkcja2(wynik1, c);
            Console.WriteLine("Objetosc figury wynosi : " + wynik2);

            Console.WriteLine("Wprowadz ilosc plynu do wypelnienia ");
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