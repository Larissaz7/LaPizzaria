<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pizzaria.aspx.cs" Inherits="LaPizza.Views.Pizzaria.Pizzaria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Sistema de Pizzaria</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            margin: 50px auto;
            width: 50%;
            text-align: center;
        }
        .form-group {
            margin: 15px 0;
        }
        label {
            font-weight: bold;
        }
        input, select {
            width: 100%;
            padding: 10px;
        }
        .btn {
            margin-top: 20px;
            padding: 10px 20px;
            background-color: #28a745;
            color: white;
            border: none;
            cursor: pointer;
        }
        .btn:hover {
            background-color: #218838;
        }
    </style>
</head>
<body>

    <div class="container">
        <h2>Pedido de Pizza</h2>
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="ddlTamanho">Tamanho da Pizza</label>
                <asp:DropDownList ID="ddlTamanho" runat="server">
                    <asp:ListItem Text="Pequena" Value="Pequena"></asp:ListItem>
                    <asp:ListItem Text="Média" Value="Média"></asp:ListItem>
                    <asp:ListItem Text="Grande" Value="Grande"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="ddlSabor">Sabor da Pizza</label>
                <asp:DropDownList ID="ddlSabor" runat="server">
                    <asp:ListItem Text="Mussarela" Value="Mussarela"></asp:ListItem>
                    <asp:ListItem Text="Calabresa" Value="Calabresa"></asp:ListItem>
                    <asp:ListItem Text="Frango com Catupiry" Value="Frango com Catupiry"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Ingredientes Extras</label>
                <asp:CheckBoxList ID="chkIngredientes" runat="server">
                    <asp:ListItem Text="Azeitona" Value="Azeitona"></asp:ListItem>
                    <asp:ListItem Text="Bacon" Value="Bacon"></asp:ListItem>
                    <asp:ListItem Text="Milho" Value="Milho"></asp:ListItem>
                </asp:CheckBoxList>
            </div>

            <div class="form-group">
                <label for="txtNomeCliente">Nome do Cliente</label>
                <asp:TextBox ID="txtNomeCliente" runat="server" />
            </div>

            <asp:Button ID="btnEnviar" runat="server" Text="Enviar Pedido" CssClass="btn" OnClick="btnEnviar_Click" />

            <asp:Label ID="lblMensagem" runat="server" Text="" ForeColor="Green" />
        </form>
    </div>
</body>
</html>
