using System;

namespace TP_3_NAIT_HADDOU_MALAK
{
    public class FormeGeometrique
    {
        // 1. Cercle : π × r²
        public double CalculerSurface(double rayon)
        {
            return Math.PI * rayon * rayon;
        }

        // 2. Carré : côté² (int pour le distinguer du cercle)
        public double CalculerSurface(int cote)
        {
            return cote * cote;
        }

        // 3. Rectangle : longueur × largeur
        public double CalculerSurface(double longueur, double largeur)
        {
            return longueur * largeur;
        }

        // 4. Triangle : formule de Héron (3 côtés)
        public double CalculerSurface(double a, double b, double c)
        {
            double p = (a + b + c) / 2;   // demi-périmètre
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}