using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LaPizza.DAL
{
    public class PedidoDAL
    {
        private string connectionString;

        public PedidoDAL()
        {
            
            connectionString = ConfigurationManager.ConnectionStrings["PizzariaDBConnection"].ConnectionString;
        }

        // Adicionar Pedido
        public void AdicionarPedido(Pedido pedido)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Pedidos (NomeCliente, Tamanho, Sabor, Ingredientes) VALUES (@NomeCliente, @Tamanho, @Sabor, @Ingredientes)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NomeCliente", pedido.NomeCliente);
                cmd.Parameters.AddWithValue("@Tamanho", pedido.Tamanho);
                cmd.Parameters.AddWithValue("@Sabor", pedido.Sabor);
                cmd.Parameters.AddWithValue("@Ingredientes", pedido.Ingredientes);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Obter Todos os Pedidos por cliente
        public List<Pedido> ObterPedidosPorCliente(string nomeCliente)
        {
            List<Pedido> pedidos = new List<Pedido>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pedidos WHERE NomeCliente = @NomeCliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NomeCliente", nomeCliente);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Pedido pedido = new Pedido
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        NomeCliente = reader["NomeCliente"].ToString(),
                        Tamanho = reader["Tamanho"].ToString(),
                        Sabor = reader["Sabor"].ToString(),
                        Ingredientes = reader["Ingredientes"].ToString(),
                        DataPedido = Convert.ToDateTime(reader["DataPedido"])
                    };
                    pedidos.Add(pedido);
                }
            }
            return pedidos;
        }

        // Excluir Pedido
        public void ExcluirPedido(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Pedidos WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Tamanho { get; set; }
        public string Sabor { get; set; }
        public string Ingredientes { get; set; }
        public DateTime DataPedido { get; internal set; }
    }
}
