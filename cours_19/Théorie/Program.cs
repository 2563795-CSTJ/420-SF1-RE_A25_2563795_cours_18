using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Théorie
{
    /*
     * nom: Hugo Gariépy
     * date: 2025/11/04
     * Fonctions
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Je veux calculer une fonction mathématique y = mx + b
            // Je demande "m" "b" "x"  et donner la valeur de "y"

            Console.Write("Entrer la valeur m: ");
            bool estMValide = double.TryParse(Console.ReadLine(), out double valeurM);
            while(!estMValide)
            {
                Console.WriteLine("Erreur: valeur 'm' doit être un nombre valide");
                Console.Write("Entrer la valeur m: ");
                estMValide = double.TryParse(Console.ReadLine(), out valeurM);
            }
            Console.Write("Entrer la valeur b: ");
            bool estBValide = double.TryParse(Console.ReadLine(), out double valeurB);
            while (!estMValide)
            {
                Console.WriteLine("Erreur: valeur 'b' doit être un nombre valide");
                Console.Write("Entrer la valeur b: ");
                estBValide = double.TryParse(Console.ReadLine(), out valeurB);
            }
            Console.Write("Entrer la valeur x: ");
            bool estXValide = double.TryParse(Console.ReadLine(), out double valeurX);
            while (!estMValide)
            {
                Console.WriteLine("Erreur: valeur 'x' doit être un nombre valide");
                Console.Write("Entrer la valeur x: ");
                estXValide = double.TryParse(Console.ReadLine(), out valeurX);
            }

            Console.WriteLine($"Y = {valeurM}*{valeurX} + {valeurB}");
            double valeurY = valeurM * valeurX + valeurB;
            Console.WriteLine($" = {valeurY}");

            //code long, répétitif (entrée utilisateur, string, tryParse, erreur ...)
            // Risque d'erreur lors des capié-collée



        }



    }
}
