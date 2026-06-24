using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace Estacionaville
{
    internal class Conexao
    {
        // Nome do arquivo do banco de dados
        private static string nomeBanco = "estacionamento.db";
        private static string stringConexao = $"Data Source={nomeBanco};Version=3;";

        // Método para garantir que o banco e a tabela existam
        public static void InicializarBanco()
        {
            if (!File.Exists(nomeBanco))
            {
                SQLiteConnection.CreateFile(nomeBanco);
            }

            using (var conn = new SQLiteConnection(stringConexao))
            {
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Vagas (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                NumeroVaga INTEGER UNIQUE,
                                Placa TEXT,
                                Status TEXT
                             )";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para executar comandos SQL (Insert, Update, Delete)
        public static void ExecutarComando(string sql)
        {
            using (var conn = new SQLiteConnection(stringConexao))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Prepara conexao com o banco de dados
        public static SQLiteConnection GetConexao()
        {
            return new SQLiteConnection(stringConexao);
        }
    }
}
