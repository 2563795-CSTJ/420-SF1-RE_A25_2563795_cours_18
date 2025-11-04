using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions
{
    internal class Program_Fonction
    {
        static void Main(string[] args)
        {
            string nom = "Fred";
            AfficherMessageTest(nom);



            double valeurM = DemanderDouble("m", out int nbErreurM);

            double valeurB = DemanderDouble("b", out int nbErreurB);

            double valeurX = DemanderDouble("x", out int nbErreurX);

            Console.WriteLine($"Y = {valeurM}*{valeurX} + {valeurB}");
            double valeurY = valeurM * valeurX + valeurB;
            Console.WriteLine($"  = {valeurY}");

        }
        // Fin du main, fonction ici:
        // private static TypeDeRetour NomDeFonction(paramètre au besoin)
        // type de retour: void (aucune valeur de retour), int, double, string, list<int>...
        // Paramètre: type nom, type nom...

        // Nom fonction: PascalCase, pas accent, verbe Daction:
        // Bien Afficher..., Calculer..., Lire...
        // mauvais: Nombre, Calcul, Faire
        // Complément le plus decriptif possible
        // Bien AfficherResultats, CalculerMoyenne
        // Mauvais Afficher, CalculerNombre
        // ex pour bool : Est..., EstNombreEntierValide

        // Faut appeler la fonction sinon rien se passe
        private static void AfficherMessageTest(string nom) //signature de la fonction
        {
            // Corps de la fonction
            Console.WriteLine($"Bonjour {nom}");
        }

        // Si veux savoir le nombre d'erreur
        // Je veux le double et les nombre d'erreuer 
        private static double DemanderDouble(string nomValeur, out int nombreErreurs)
        {
            nombreErreurs = 0;
            Console.Write($"Entrer la valeur {nomValeur}: ");
            bool estValide = double.TryParse(Console.ReadLine(), out double valeur);
            while (!estValide)
            {
                Console.WriteLine($"Erreur: valeur {nomValeur} doit être un nombre valide");
                Console.Write($"Entrer la valeur {nomValeur}: ");
                estValide = double.TryParse(Console.ReadLine(), out valeur);
                nombreErreurs++;
            }
            return valeur;
        }
    }
}
