using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projektRabat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość zakupów: ");
            int cena = int.Parse(Console.ReadLine());
            if (cena > 400)
            {
                //cena -= 80;
                cena = cena - 80;
                Console.WriteLine("Rabat wynosi 80 zł");

            }
            else
            {
                if (cena > 200)
                {
                    cena -= 35;
                    Console.WriteLine("Rabat wynosi 35 zł");
                } else
                {
                    if (cena > 100)
                    {
                        cena -= 15;
                        Console.WriteLine("Rabat wynosi 15 zł");
                    }
                    else 
                    {

                        Console.WriteLine("Brak rabatu");
                    }

                }
            }
            Console.WriteLine("Do zapłaty po rabacie: ");
            Console.WriteLine(cena);
            Console.Read();
        }
    }
}
