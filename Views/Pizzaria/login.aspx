<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LaPizza.Views.Pizzaria.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .container {
            margin: 50px auto;
            width: 30%;
            text-align: center;
        }
        .form-group {
            margin: 15px 0;
        }
        label {
            font-weight: bold;
        }
        input {
            width: 100%;
            padding: 10px;
        }
        .btn {
            margin-top: 20px;
            padding: 10px 20px;
            background-color: #007bff;
            color: white;
            border: none;
            cursor: pointer;
        }
        .btn:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <div class="container">
        <h2>Login</h2>
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="txtUsuario">Usuário</label>
                <asp:TextBox ID="txtUsuario" runat="server" />
            </div>
            <div class="form-group">
                <label for="txtSenha">Senha</label>
                <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" />
            </div>
            <asp:Button ID="btnLogin" runat="server" Text="Entrar" CssClass="btn" OnClick="btnLogin_Click" />
            <asp:Label ID="lblMensagem" runat="server" Text="" ForeColor="Red" />
        </form>
    </div>
</body>
</html>