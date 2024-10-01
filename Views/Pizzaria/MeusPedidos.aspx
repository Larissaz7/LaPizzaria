<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MeusPedidos.aspx.cs" Inherits="LaPizza.Views.Pizzaria.MeusPedidos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Meus Pedidos</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
        }

        h2 {
            text-align: center;
            color: #333;
        }

        .card {
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            padding: 20px;
            margin: 20px 0;
        }

        .grid-container {
            width: 100%;
            overflow-x: auto;
        }

        table {
            width: 100%;
            border-collapse: collapse;
        }

        th, td {
            text-align: left;
            padding: 12px;
        }

        th {
            background-color: #4CAF50;
            color: white;
        }

        tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        tr:hover {
            background-color: #ddd;
        }

        .footer {
            text-align: center;
            margin-top: 20px;
            font-size: 0.9em;
            color: #777;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Meus Pedidos</h2>

            <asp:Label ID="lblMensagem" runat="server" ForeColor="Red" />

            <div class="card">
                <div class="grid-container">
                    <asp:GridView ID="gvPedidos" runat="server" AutoGenerateColumns="false" CssClass="table table-striped table-bordered">
                        <Columns>
                            <asp:BoundField DataField="NomeCliente" HeaderText="Nome do Cliente" />
                            <asp:BoundField DataField="Tamanho" HeaderText="Tamanho" />
                            <asp:BoundField DataField="Sabor" HeaderText="Sabor" />
                            <asp:BoundField DataField="Ingredientes" HeaderText="Ingredientes" />
                            <asp:BoundField DataField="DataPedido" HeaderText="Data do Pedido" DataFormatString="{0:dd/MM/yyyy HH:mm}" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <div class="footer">
                © 2024 LaPizza. Todos os direitos reservados.
            </div>
        </div>
    </form>
</body>
</html>
