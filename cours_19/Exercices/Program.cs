using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices
{
    //Exercices
    internal class Program
    {
        static void Main(string[] args)
        {
            double premierNombre = VerifierLesNombres();

            double deuxiemeNombre = VerifierLesNombres();
            Console.WriteLine();
            Console.WriteLine($"Minimum = {TrouverMinimum(premierNombre, deuxiemeNombre)}");
            Console.WriteLine($"Maximum = {TrouverMaximum(premierNombre, deuxiemeNombre)}\n");
            Console.WriteLine($"Le nombre {premierNombre} est pair : {EstUnNombrePair(premierNombre)}");
            Console.WriteLine($"Le nombre {deuxiemeNombre} est pair : {EstUnNombrePair(deuxiemeNombre)}");
        }
        private static double VerifierLesNombres()
        {
            Console.Write("Entrer un chiffre :");
            bool chiffreValide = double.TryParse(Console.ReadLine(), out double nombre);
            while(!chiffreValide)
            {
                Console.WriteLine("Erreur : le nombre n'est pas valide");
                Console.Write("Entrer un nombre :");
                chiffreValide = double.TryParse(Console.ReadLine(), out nombre);
            }
            return nombre;
        }
        private static double TrouverMinimum(double nombre1, double nombre2)
        {
            double resultat = nombre1 - nombre2;
            double minimum = 0;
            if (resultat == 0)
            {
                Console.WriteLine("Les deux nombres sont identiques");
            }
            else if (resultat < 0)
            {
                minimum = nombre1;
            }
            else if (resultat > 0)
            {
                minimum = nombre2;
            }
            return minimum;

        }

        private static double TrouverMaximum(double nombre1, double nombre2)
        {
            double resultat = nombre1 - nombre2;
            double maximum = 0;
            if (resultat == 0)
            {
                Console.WriteLine("Les deux nombres sont identiques");
            }
            else if (resultat < 0)
            {
                maximum = nombre2;
            }
            else if (resultat > 0)
            {
                maximum = nombre1;
            }
            return maximum;
        }
        private static bool EstUnNombrePair(double nombre)
        {
            bool reponse;
            if(nombre%2 == 0)
            {
                reponse = true;
            }
            else
                {
                reponse = false;

            }
                return reponse;
        }

    }
}
