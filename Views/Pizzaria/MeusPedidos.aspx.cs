using LaPizza.DAL;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;

namespace LaPizza.Views.Pizzaria
{
    public partial class MeusPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["NomeCliente"] != null)
                {
                    string nomeCliente = Session["NomeCliente"].ToString();

                    try
                    {
                        
                        PedidoDAL dal = new PedidoDAL();
                        var pedidos = dal.ObterPedidosPorCliente(nomeCliente);

                        if (pedidos != null && pedidos.Count > 0)
                        {
                            gvPedidos.DataSource = pedidos;
                            gvPedidos.DataBind();
                        }
                        else
                        {
                            lblMensagem.Text = "Você ainda não fez nenhum pedido.";
                        }
                    }
                    catch (Exception ex)
                    {
                        
                        lblMensagem.Text = "Ocorreu um erro ao carregar seus pedidos. Tente novamente mais tarde.";
                        
                    }
                }
                else
                {
                    
                    Response.Redirect("~/Login.aspx");
                }
            }
        }
    }

    // Classe Pedido, se não estiver definida em outro lugar
    public class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Tamanho { get; set; }
        public string Sabor { get; set; }
        public string Ingredientes { get; set; }
        public DateTime DataPedido { get; set; }
    }
}
