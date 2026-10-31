using System;

namespace TP_3_NAIT_HADDOU_MALAK
{
    internal class Eleve
    {
        // 1. Attributs
        private string nom;
        private string prenom;
        private double[] notes = new double[3];
        private static int nombreEleves = 0;  // Attribut STATIQUE (partagé par tous les objets)

        // 2. Propriétés d'accès
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public double[] Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public static int NombreEleves
        {
            get { return nombreEleves; }
        }

        // 3. Constructeur par défaut (nom = "Anonyme", notes = 0)
        public Eleve()
        {
            nom = "Anonyme";
            prenom = "Anonyme";
            notes = new double[] { 0, 0, 0 };
            nombreEleves++;
        }

        // 4. Constructeur d'initialisation (avec paramètres)
        public Eleve(string nom, string prenom, double[] notes)
        {
            this.nom = nom;
            this.prenom = prenom;
            // On copie le tableau pour éviter les problèmes de référence
            this.notes = new double[3];
            for (int i = 0; i < 3; i++)
            {
                this.notes[i] = notes[i];
            }
            nombreEleves++;
        }

        // 5. Constructeur de recopie (clone un objet existant)
        public Eleve(Eleve autreEleve)
        {
            this.nom = autreEleve.nom;
            this.prenom = autreEleve.prenom;
            this.notes = new double[3];
            for (int i = 0; i < 3; i++)
            {
                this.notes[i] = autreEleve.notes[i];
            }
            nombreEleves++;
        }

        // 6. Méthode Moyenne
        public double Moyenne()
        {
            double somme = 0;
            for (int i = 0; i < 3; i++)
            {
                somme += notes[i];
            }
            return somme / 3;
        }

        // 7. Méthode Afficher
        public void Afficher()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Nom complet : " + nom + " " + prenom);
            Console.WriteLine("Notes :");
            Console.WriteLine("  - Note 1 : " + notes[0]);
            Console.WriteLine("  - Note 2 : " + notes[1]);
            Console.WriteLine("  - Note 3 : " + notes[2]);
            Console.WriteLine("Moyenne : " + Moyenne().ToString("0.00"));
            Console.WriteLine("================================");
        }
    }
}