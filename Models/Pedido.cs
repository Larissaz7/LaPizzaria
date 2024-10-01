using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaPizza.Models
{
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