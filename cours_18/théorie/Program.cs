using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace théorie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Effectuer des opérations de programmation communes, math avancés.
            // Math
            double pi = Math.PI;
            double e = Math.E;

            Math.Sqrt(100); // 10

            Math.Pow(3, 2); // 9

            // chaine de caractère (string)
            string nom = "Frederic";
            
            nom.ToLower(); // met un minuscule
            nom.ToUpper(); // met en majuscule

            string entree = "                 155 blv. Industriel      ";

            Console.WriteLine(entree.Trim()); //Enleve les espaces extérieur

            // On peut chainer
            string prenom = "       fREdeRiC    ";

            //  "       fREdeRiC    " ---Uper--> "   FREDERIC  " ---trim--> "FREDERIC"
            Console.WriteLine(prenom.ToUpper().Trim());

            // Obetenir des char d'une string
            // string = tableau de char ['f', 'e', ...]
            string nomPrenom = "Labelle,Frederic";

            string justeLeNom = nomPrenom.Substring(0, 7);   // (index de depart, longueur)

            string justeLePrenom = nomPrenom.Substring(8, 8);

            Console.WriteLine(justeLeNom);
            Console.WriteLine(justeLePrenom);

            // Obtenir le "7" et le "8" dynamiquement
            int indexVirgule = nomPrenom.IndexOf(",");
            Console.WriteLine(indexVirgule);
            // bonne façon:
            justeLeNom = nomPrenom.Substring(0, indexVirgule);
            justeLePrenom = nomPrenom.Substring(indexVirgule + 1, nomPrenom.Length - justeLeNom.Length - 1);
            Console.WriteLine(justeLeNom);
            Console.WriteLine(justeLePrenom);

            // Random
            Random random = new Random();
            int entierAleatoire = random.Next(20, 30);  // [20, 30[
            double doubleAleatoire = random.NextDouble(); // ­[0, 1[



        }
    }
}
