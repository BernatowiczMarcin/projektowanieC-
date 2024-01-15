using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekcjaKO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj, za chwile utworzymy obiekt w klasie 'Człowiek' !");
           
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Podaj imię pierwszego obiektu : ");
            string name = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj nazwisko pierwszego obiektu : ");
            string surname = Console.ReadLine();

            Czlowiek pierwszy = new Czlowiek(name,surname);

            Console.ForegroundColor = ConsoleColor.White;
            pierwszy.PrzedstawSie();
            
            
            Console.ReadKey();
        }
    }
    

}