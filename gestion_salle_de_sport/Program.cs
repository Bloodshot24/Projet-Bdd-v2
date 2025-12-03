// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

Console.WriteLine("Bon venez on taff fort");
Console.ReadKey(); 

public class Admin
{
    public int ID_Admin { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Nv_Privilege { get; set; }
    public string MDP { get; set; }
}

public class Coach
{
    public int ID_Coach { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Tel { get; set; }
    public string MDP { get; set; }
    public string Formation { get; set; }
    public string Specialite { get; set; }
}

public class Cours
{
    public int ID_Cours { get; set; }
    public string Nom_Cours { get; set; }
    public string Description { get; set; }
    public decimal Duree_h_min { get; set; }
    public int Intensite { get; set; }
    public string Difficulte { get; set; }
    public int Capacite { get; set; }
}

public class Salle
{
    public int ID_Salle { get; set; }
    public string Nom_Salle { get; set; }
    public string Localisation { get; set; }
    public int Capacite { get; set; }
}

public class Membre
{
    public int ID_Membre { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Adresse { get; set; }
    public int Tel { get; set; }
    public string Mail { get; set; }
    public DateTime Date_Inscription { get; set; }
    public bool Validite_Inscription { get; set; }
    public string MDP { get; set; }
    public int ID_Admin { get; set; }
}

public class Planning
{
    public int ID_Planning { get; set; }
    public int ID_Coach { get; set; }
    public int ID_Cours { get; set; }
    public int ID_Salle { get; set; }
    public DateTime Date_H_Debut { get; set; }
    public DateTime Date_H_Fin { get; set; }
}

public class Inscription
{
    public int ID_Membre { get; set; }
    public int ID_Cours { get; set; }
}

public class Database
{
    public List<Admin> Admins = new List<Admin>
    {
        new Admin { ID_Admin = 1, Nom = "Martin", Prenom = "Leo", Nv_Privilege = 1, MDP = "admin123" },
        new Admin { ID_Admin = 2, Nom = "Durand", Prenom = "Eva", Nv_Privilege = 2, MDP = "securepass" },
        new Admin { ID_Admin = 3, Nom = "Petit", Prenom = "Lina", Nv_Privilege = 1, MDP = "password" }
    };

    public List<Coach> Coaches = new List<Coach>
    {
        new Coach { ID_Coach = 1, Nom = "Moreau", Prenom = "Thomas", Tel = 0610203040, MDP = "coach1", Formation = "BPJEPS", Specialite = "Musculation" },
        new Coach { ID_Coach = 2, Nom = "Rossi", Prenom = "Laura", Tel = 0622334455, MDP = "coach2", Formation = "Licence STAPS", Specialite = "Cardio" },
        new Coach { ID_Coach = 3, Nom = "Bernard", Prenom = "Alex", Tel = 0677889900, MDP = "coach3", Formation = "Brevet d’État", Specialite = "CrossFit" }
    };

    public List<Cours> CoursList = new List<Cours>
    {
        new Cours { ID_Cours = 1, Nom_Cours = "Yoga", Description = "Relaxation et respiration", Duree_h_min = 1.00m, Intensite = 2, Difficulte = "Facile", Capacite = 20 },
        new Cours { ID_Cours = 2, Nom_Cours = "HIIT", Description = "Entraînement intensif", Duree_h_min = 0.75m, Intensite = 5, Difficulte = "Difficile", Capacite = 15 },
        new Cours { ID_Cours = 3, Nom_Cours = "Zumba", Description = "Danse cardio", Duree_h_min = 1.00m, Intensite = 3, Difficulte = "Moyenne", Capacite = 25 },
        new Cours { ID_Cours = 4, Nom_Cours = "Musculation", Description = "Travail avec charges", Duree_h_min = 1.50m, Intensite = 4, Difficulte = "Moyenne", Capacite = 20 }
    };

    public List<Salle> Salles = new List<Salle>
    {
        new Salle { ID_Salle = 1, Nom_Salle = "ZenRoom", Localisation = "Étage 1", Capacite = 20 },
        new Salle { ID_Salle = 2, Nom_Salle = "PowerRoom", Localisation = "Étage 2", Capacite = 25 },
        new Salle { ID_Salle = 3, Nom_Salle = "DanceHall", Localisation = "RDC", Capacite = 30 }
    };

    public List<Membre> Membres = new List<Membre>
    {
        new Membre { ID_Membre = 1, Nom = "Dubois", Prenom = "Marie", Adresse = "12 rue des Fleurs", Tel = 0611121314, Mail = "marie@mail.com", Date_Inscription = DateTime.Parse("2025-01-12"), Validite_Inscription = true, MDP = "marie123", ID_Admin = 1 },
        new Membre { ID_Membre = 2, Nom = "Lambert", Prenom = "Paul", Adresse = "45 avenue du Parc", Tel = 0625252525, Mail = "paul@mail.com", Date_Inscription = DateTime.Parse("2025-02-05"), Validite_Inscription = true, MDP = "paul123", ID_Admin = 2 },
        new Membre { ID_Membre = 3, Nom = "Garcia", Prenom = "Nina", Adresse = "3 rue des Oliviers", Tel = 0639393939, Mail = "nina@mail.com", Date_Inscription = DateTime.Parse("2025-01-28"), Validite_Inscription = false, MDP = "nina123", ID_Admin = 1 }
    };

    public List<Planning> Plannings = new List<Planning>
    {
        new Planning { ID_Planning = 1, ID_Coach = 1, ID_Cours = 1, ID_Salle = 1, Date_H_Debut = DateTime.Parse("2025-03-10 09:00"), Date_H_Fin = DateTime.Parse("2025-03-10 10:00") },
        new Planning { ID_Planning = 2, ID_Coach = 2, ID_Cours = 2, ID_Salle = 2, Date_H_Debut = DateTime.Parse("2025-03-10 18:00"), Date_H_Fin = DateTime.Parse("2025-03-10 18:45") },
        new Planning { ID_Planning = 3, ID_Coach = 3, ID_Cours = 3, ID_Salle = 3, Date_H_Debut = DateTime.Parse("2025-03-11 17:00"), Date_H_Fin = DateTime.Parse("2025-03-11 18:00") }
    };

    public List<Inscription> Inscriptions = new List<Inscription>
    {
        new Inscription { ID_Membre = 1, ID_Cours = 1 },
        new Inscription { ID_Membre = 1, ID_Cours = 3 },
        new Inscription { ID_Membre = 2, ID_Cours = 2 },
        new Inscription { ID_Membre = 3, ID_Cours = 1 }
    };
}