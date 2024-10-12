using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varijableDrugiZadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
        } }

        
namespace BrojeviUdvostruceni
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Tražimo od korisnika da unese cijeli i decimalni broj
                Console.WriteLine("Unesite cijeli broj i decimalni broj, odvojene razmakom:");

                // Čitamo unos korisnika
                string input = Console.ReadLine();

                // Dijelimo unesene vrijednosti na dva dijela
                string[] parts = input.Split(' ');

                // Provjeravamo jesu li uneseni ispravni brojevi
                if (parts.Length == 2 &&
                    int.TryParse(parts[0], out int cijeliBroj) &&
                    double.TryParse(parts[1], out double decimalniBroj))
                {
                    // Udvostručujemo unesene brojeve
                    double x = cijeliBroj * 2;
                    double y = decimalniBroj * 2;

                    // Ispisujemo rezultate
                    Console.WriteLine($"Udvostručeni cijeli broj (x): {x}");
                    Console.WriteLine($"Udvostruženi decimalni broj (y): {y}");
                }
                else
                {
                    Console.WriteLine("Unos nije ispravan. Molimo unesite jedan cijeli i jedan decimalni broj.");
                }
            }
        }
    }






}





