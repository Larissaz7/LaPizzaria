using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaPizza.Views.Pizzaria
{
    public partial class login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
          
            if (txtUsuario.Text == "admin" && txtSenha.Text == "senha")
            {
                Session["UsuarioLogado"] = txtUsuario.Text; 
                Response.Redirect("MeusPedidos.aspx"); 
            }
            else
            {
                lblMensagem.Text = "Usuário ou senha inválidos.";
            }
        }
    }
}