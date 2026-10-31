# TP 3 : Classes et Objets (C#)

**Réalisé par :** NAIT HADDOU Malak

**Module :** DotNet / Programmation Orientée Objet


## 📌 Objectifs du TP
Ce travail pratique a pour but de manipuler les concepts fondamentaux de la Programmation Orientée Objet (POO) en C# :
*   Manipuler les classes et les objets.
*   Créer et utiliser différents types de constructeurs (par défaut, d'initialisation, de recopie).
*   Utiliser les membres statiques.
*   Manipuler la surcharge des méthodes.

---

## 📂 Structure du projet

Le projet est organisé avec un fichier par classe pour plus de clarté :

*   📄 **`Livre.cs`** : Correspond à l'**Exercice 1**. Contient la classe `Livre` avec ses attributs (Titre, Auteur, Prix), propriétés d'accès, constructeur et méthode `Afficher()`.
*   📄 **`Eleve.cs`** : Correspond à l'**Exercice 2**. Contient la classe `Eleve` avec un tableau de 3 notes, un compteur statique, trois constructeurs (défaut, initialisation, recopie) et une méthode `Moyenne()`.
*   📄 **`FormeGeometrique.cs`** : Correspond à l'**Exercice 3**. Contient la classe `FormeGeometrique` illustrant la **surcharge de méthodes** (`CalculerSurface`) pour un cercle, un carré, un rectangle et un triangle.
*   📄 **`Program.cs`** : Contient la méthode `Main` servant de classe de test pour instancier les objets et exécuter le programme.

---

## 🛠️ Détails des Exercices

### Exercice 1 : Classe Livre
*   Création d'un livre avec un titre, un auteur et un prix.
*   Test effectué avec le livre *"November 9"* de *Colleen Hoover*.

### Exercice 2 : Classe Eleve
*   Gestion des notes d'un élève dans un tableau de taille 3.
*   **Constructeur par défaut** : Initialise le nom à "Anonyme" et les notes à 0.
*   **Constructeur d'initialisation** : Les informations du 2ème élève sont demandées à l'utilisateur via la console (`Console.ReadLine`).
*   **Constructeur de recopie** : Le 3ème élève est une copie conforme du 2ème (clonage indépendant en mémoire).
*   Utilisation d'un attribut `static` pour compter le nombre total d'élèves instanciés.

### Exercice 3 : Forme Géométrique
*   Mise en pratique de la **surcharge de méthodes** : la méthode `CalculerSurface` est définie 4 fois avec des signatures différentes.
*   *Cercle* : `CalculerSurface(double rayon)`
*   *Carré* : `CalculerSurface(int cote)`
*   *Rectangle* : `CalculerSurface(double longueur, double largeur)`
*   *Triangle* : `CalculerSurface(double a, double b, double c)` en utilisant la formule mathématique de **Héron** (calcul à partir des 3 côtés).

---


*Projet réalisé dans le cadre des travaux pratiques de DotNet.*
