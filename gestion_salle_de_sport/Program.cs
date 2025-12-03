using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace SalleSportApp
{
    internal class Program
    {
        // - Server : ton serveur (localhost, 127.0.0.1, etc.)
        // - Database : tu peux mettre "" si le script contient CREATE DATABASE + USE
        // - User Id / Password : ton compte MySQL
        private const string connectionString =
            "Server=127.0.0.1;User Id=root;Password=motdepassesql ;";

        private const string sqlFileName = "/Users/bas/Documents/Bastien/ESILV/A2/BDD/Projet bdd/Projet-Bdd-v2/gestion_salle_de_sport/base_de_donnee_sport.sql";

        static void Main(string[] args)
        {
            try
            {
                //Charger le script SQL
                string exeDir = AppDomain.CurrentDomain.BaseDirectory;
                string sqlPath = Path.Combine(exeDir, sqlFileName);

                if (!File.Exists(sqlPath))
                {
                    Console.WriteLine($"Fichier SQL introuvable : {sqlPath}");
                    return;
                }

                string sqlScript = File.ReadAllText(sqlPath);

                //on execute le script afin de créer la base et les tables et d'ajouter les valerus
                ExecuterScriptSql(sqlScript);

                Console.WriteLine("Script SQL exécuté avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
            }
        }

        private static void ExecuterScriptSql(string script)
        {
            using (var connexion = new MySqlConnection(connectionString))
            {
                connexion.Open();

                // on cree un tableau selon les points virgules
                string[] commandes = script.Split(new[] { ';' });

                foreach (var c in commandes)
                {
                    if (string.IsNullOrWhiteSpace(c))
                        continue;

                    using (var cmd = new MySqlCommand(c, connexion))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void AfficherMembres()
        {
            using (var connexion = new MySqlConnection(connectionString + "Database=salle_sport;"))
            {
                connexion.Open();

                string sql = "SELECT ID_Membre, Nom, Prenom, Mail FROM Membre ORDER BY ID_Membre;";

                using (var cmd = new MySqlCommand(sql, connexion))
                using (var reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("Liste des membres :");
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("ID_Membre");
                        string nom = reader.GetString("Nom");
                        string prenom = reader.GetString("Prenom");
                        string mail = reader.IsDBNull(reader.GetOrdinal("Mail"))
                                      ? "" : reader.GetString("Mail");

                        Console.WriteLine($"{id} - {nom} {prenom} ({mail})");
                    }
                }
            }
        }
   }