using System;
using System.Collections.Generic;
using WebApp5EMVC.Models.Entity;
using System.Configuration;
using MySql.Data.MySqlClient;
using Dapper;
using System.Linq;

namespace WebApp5EMVC.Helpers
{
    public static class DatabaseHelper
    {
        public static string _connectionString { get; set; }

        public static void InitConnectionString(string cs)
        {
            _connectionString = cs;
        }

        public static List<Prodotto> GetAllProdotti()
        {
            var prodotti = new List<Prodotto>();
            using (var connection = new MySqlConnection(_connectionString)) {
                var sql = "SELECT * FROM Prodotto";
                prodotti = connection.Query<Prodotto>(sql).ToList();
            }
            return prodotti;
        }

        public static Prodotto GetProdottoByID(int id)
        {
            var prodotto = new Prodotto();
            using(var connection = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM Prodotto WHERE id = @id";
                prodotto = connection.Query<Prodotto>(sql, new { id }).FirstOrDefault();

            }
            return prodotto;
        }

        public static bool ExistsEmail (string email)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var sql = "SELECT id FROM Utente WHERE email = @email";
                var id = connection.Query<int>(sql, new { email }).FirstOrDefault();
                return id > 0;
            }
        }

        public static int InsertUtente(Utente utente)
        {
            var id = 0;
            try
            {
                using(var connection = new MySqlConnection(_connectionString))
                {
                    var sql = "INSERT INTO Utente (nome, email, password, isprivacy) VALUES (@nome, @email, @password, 1); SELECT LAST_INSERT_ID();";
                    id = connection.Query<int>(sql, utente).First();
                }
            } catch(Exception gg)
            {
                //TODO loggare l'errore ex.Message
            }
            return id;
        }

        public static bool UpdatePassword(int id, string password)
        {
            try
            {
                using(var connection = new MySqlConnection(_connectionString))
                {
                    var sql = "UPDATE Utente SET password = @password WHERE id = @id";
                    connection.Query(sql, new { id, password });
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
