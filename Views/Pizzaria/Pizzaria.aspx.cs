using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;
using LaPizza.DAL;  

namespace LaPizza.Views.Pizzaria
{
    public partial class Pizzaria : System.Web.UI.Page
    {
        PedidoDAL pedidoDAL = new PedidoDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        //protected void btnMeusPedidos_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("MeusPedidos.aspx");
        //}

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            
            LaPizza.DAL.Pedido novoPedido = new LaPizza.DAL.Pedido
            {
                NomeCliente = txtNomeCliente.Text,
                Tamanho = ddlTamanho.SelectedValue,
                Sabor = ddlSabor.SelectedValue,
                Ingredientes = GetSelectedIngredients()
            };

            pedidoDAL.AdicionarPedido(novoPedido);

            lblMensagem.Text = "Pedido enviado com sucesso!";

            LimparCampos();
        }


        private string GetSelectedIngredients()
        {
            List<string> ingredientesSelecionados = new List<string>();
            foreach (ListItem item in chkIngredientes.Items)
            {
                if (item.Selected)
                {
                    ingredientesSelecionados.Add(item.Value);
                }
            }
            return string.Join(", ", ingredientesSelecionados);
        }


        private void LimparCampos()
        {
            txtNomeCliente.Text = string.Empty;
            ddlTamanho.SelectedIndex = 0;
            ddlSabor.SelectedIndex = 0;
            foreach (ListItem item in chkIngredientes.Items)
            {
                item.Selected = false; 
            }
        }

    }
}
