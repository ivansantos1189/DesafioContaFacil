using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ContaFacil.Core.WebAPI;
using ContaFacil.WebAPI.Core.User;

namespace ContaFacil.CurrentAccounts.API.Controllers
{
    [Authorize]
    public class CurrentAccountController : MainController
    {

        private readonly IAspNetUser _user;

        public CurrentAccountController(IAspNetUser user)
        {
            _user = user;
        }

        [HttpPost("pedido")]
        public async Task<IActionResult> AdicionarPedido(AdicionarPedidoCommand pedido)
        {
            pedido.ClienteId = _user.ObterUserId();
            return CustomResponse(await _mediator.EnviarComando(pedido));
        }

        [HttpGet("pedido/ultimo")]
        public async Task<IActionResult> UltimoPedido()
        {
            var pedido = await _pedidoQueries.ObterUltimoPedido(_user.ObterUserId());

            return pedido == null ? NotFound() : CustomResponse(pedido);
        }

        [HttpGet("pedido/lista-cliente")]
        public async Task<IActionResult> ListaPorCliente()
        {
            var pedidos = await _pedidoQueries.ObterListaPorClienteId(_user.ObterUserId());

            return pedidos == null ? NotFound() : CustomResponse(pedidos);
        }
    }
}