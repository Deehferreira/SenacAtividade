using System;
using System.Collections.Generic;
using MySqlConnector;

namespace EstudoBC.Models
{
    public class PacotesRepository
    {
        private const string _strConexao = "Database=ProjCadastros;Data Source=localhost;User Id=root;Password=amarelo#15";
        public void Insert(Pacotes p)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "INSERT INTO Pacotes(nome, origem, destino, atrativos, saida, retorno, usuario) VALUES (@Nome, @origem, @destino, @atrativos, @saida, @retorno, @usuario)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", p.Nome);
            comando.Parameters.AddWithValue("@Origem",p.Origem);
            comando.Parameters.AddWithValue("@Destino", p.Destino);
            comando.Parameters.AddWithValue("@Atrativos", p.Atrativos);
            comando.Parameters.AddWithValue("@Saida", p.Saida);
            comando.Parameters.AddWithValue("@Retorno", p.Retorno);
            comando.Parameters.AddWithValue("@usuario", p.usuario);
            comando.ExecuteNonQuery();
            conexao.Close();
        } 
        public List<Pacotes> Query()
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "SELECT * FROM Pacotes ORDER BY id";
            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            List<Pacotes> lista = new List<Pacotes>();
             while (reader.Read())
    {
            Pacotes usr = new Pacotes();
            if(!reader.IsDBNull(reader.GetOrdinal("Id")))
                usr.Id = reader.GetInt32("Id");
       
            if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                usr.Nome = reader.GetString("Nome");
       
            if(!reader.IsDBNull(reader.GetOrdinal("Origem")))
                usr.Origem = reader.GetString("Origem");

            if(!reader.IsDBNull(reader.GetOrdinal("Destino")))
                usr.Destino = reader.GetString("Destino");

            if(!reader.IsDBNull(reader.GetOrdinal("Atrativos")))
                usr.Atrativos = reader.GetString("Atrativos");

            if(!reader.IsDBNull(reader.GetOrdinal("Saida")))
                usr.Saida = reader.GetDateTime("Saida");
    
            if(!reader.IsDBNull(reader.GetOrdinal("Retorno")))
                usr.Retorno = reader.GetDateTime("Retorno"); 
            if(!reader.IsDBNull(reader.GetOrdinal("usuario")))
                usr.usuario = reader.GetInt32("usuario");  
            lista.Add(usr);
        }
            conexao.Close();
            return lista;
        }
        public void Editar(Pacotes p)
        {

            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "UPDATE Pacotes set";
            sql = sql + " nome = @Nome, origem = @Origem, destino = @Destino, atrativos = @Atrativos,";
            sql = sql + " saida = @Saida, retorno = @Retorno, usuario = @usuario";
            sql = sql + " WHERE id = @Id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", p.Id);
            comando.Parameters.AddWithValue("@Nome", p.Nome);
            comando.Parameters.AddWithValue("@Origem", p.Origem);
            comando.Parameters.AddWithValue("@Destino", p.Destino);
            comando.Parameters.AddWithValue("@Atrativos", p.Atrativos);
            comando.Parameters.AddWithValue("@Saida", p.Saida);
            comando.Parameters.AddWithValue("@Retorno", p.Retorno);
            comando.Parameters.AddWithValue("@usuario", p.usuario);
            
            comando.ExecuteNonQuery();

            conexao.Close();
        }
         public void Excluir(Pacotes p)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "Delete FROM Pacotes WHERE id= @Id";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", p.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}