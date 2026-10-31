using System;
using System.Collections.Generic;
using System.Text;

namespace TP_3_NAIT_HADDOU_MALAK
{
    internal class Livre
    {
        // 1. Attributs (privés)
        private string titre;
        private string auteur;
        private double prix;

        // 2. Propriétés d'accès (publiques)
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        // 3. Constructeur
        public Livre(string titre, string auteur, double prix)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.prix = prix;
        }

        // 4. Méthode Afficher
        public void Afficher()
        {
            Console.WriteLine("--- Informations du Livre ---");
            Console.WriteLine("Titre  : " + titre);
            Console.WriteLine("Auteur : " + auteur);
            Console.WriteLine("Prix   : " + prix + " DH");
        }
    }
}