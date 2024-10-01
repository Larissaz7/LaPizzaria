using LaPizza.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LaPizza.Controllers
{
    
    public class PedidosController : ApiController
    {
        PedidoDAL pedidoDAL = new PedidoDAL();

        
        [HttpGet]
        public IHttpActionResult Get()
        {
            
            string nomeCliente = HttpContext.Current.Session["NomeCliente"]?.ToString();
            if (string.IsNullOrEmpty(nomeCliente))
            {
                return BadRequest("Cliente não está logado.");
            }

            var pedidos = pedidoDAL.ObterPedidosPorCliente(nomeCliente);
            return Ok(pedidos);
        }

        
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
           
            string nomeCliente = HttpContext.Current.Session["NomeCliente"]?.ToString();
            if (string.IsNullOrEmpty(nomeCliente))
            {
                return BadRequest("Cliente não está logado.");
            }

            var pedidos = pedidoDAL.ObterPedidosPorCliente(nomeCliente);
            var pedido = pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        
        [HttpPost]
        public IHttpActionResult Post([FromBody] Pedido novoPedido)
        {
            if (novoPedido == null)
            {
                return BadRequest("Pedido inválido.");
            }

            pedidoDAL.AdicionarPedido(novoPedido);
            return Ok(novoPedido);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            pedidoDAL.ExcluirPedido(id);
            return Ok($"Pedido {id} removido com sucesso.");
        }
    }
}
