/*using System;

namespace TP_3_NAIT_HADDOU_MALAK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Livre monLivre = new Livre("November 9", "Colleen Hoover", 120.00);

            monLivre.Afficher();

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}*/
/*using System;

namespace TP_3_NAIT_HADDOU_MALAK
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Eleve eleve1 = new Eleve();

            
            Console.WriteLine("=== Saisie des informations du 2ème élève ===");

            Console.Write("Entrez votre nom : ");
            string nom = Console.ReadLine();

            Console.Write("Entrez votre prénom : ");
            string prenom = Console.ReadLine();

            double[] notes = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Entrez la note " + (i + 1) + " : ");
                notes[i] = double.Parse(Console.ReadLine());
            }

            Eleve eleve2 = new Eleve(nom, prenom, notes);

           
            Eleve eleve3 = new Eleve(eleve2);

           
            Console.WriteLine("\n\n===== Élève 1 (par défaut) =====");
            eleve1.Afficher();

            Console.WriteLine("\n===== Élève 2 (moi) =====");
            eleve2.Afficher();

            Console.WriteLine("\n===== Élève 3 (copie du 2ème) =====");
            eleve3.Afficher();

           
            Console.WriteLine("\nNombre total d'élèves créés : " + Eleve.NombreEleves);

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}*/
using System;

namespace TP_3_NAIT_HADDOU_MALAK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormeGeometrique f = new FormeGeometrique();

            Console.WriteLine("Cercle (r=5.0)        : " + f.CalculerSurface(5.0).ToString("0.00"));
            Console.WriteLine("Carré (côté=4)        : " + f.CalculerSurface(4).ToString("0.00"));
            Console.WriteLine("Rectangle (6.0 x 3.0) : " + f.CalculerSurface(6.0, 3.0).ToString("0.00"));
            Console.WriteLine("Triangle (3, 4, 5)    : " + f.CalculerSurface(3.0, 4.0, 5.0).ToString("0.00"));

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}