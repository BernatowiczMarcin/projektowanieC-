using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekcjaKO
{
    class Czlowiek
    {
        public Czlowiek()
        {
            
        }

        public Czlowiek(string imieKonstruktora) 
        {
            imie = imieKonstruktora;
        }
        
        public Czlowiek(string imieKonstruktora, string nazwiskokons)
        {
            imie = imieKonstruktora;
            nazwisko = nazwiskokons;
        }
        public string imie = "BRAK";
        public string nazwisko  = "BRAK";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imię : {0} , a na nazwisko : {1} " + imie,nazwisko);
        }
    }
}
