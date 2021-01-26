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
    }
}
