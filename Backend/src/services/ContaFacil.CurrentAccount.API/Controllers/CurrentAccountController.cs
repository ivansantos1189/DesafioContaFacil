using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ContaFacil.Core.WebAPI;
using ContaFacil.WebAPI.Core.User;
using ContaFacil.CurrentAccount.API.Models;
using ContaFacil.CurrentAccount.Domain;

namespace ContaFacil.CurrentAccounts.API.Controllers
{
    [Authorize]
    public class CurrentAccountController : MainController
    {

        private readonly IAspNetUser _user;
        private readonly ICurrentAccountService _currentAccountService;

        public CurrentAccountController(IAspNetUser user, ICurrentAccountService currentAccountService)
        {
            _user = user;
            _currentAccountService = currentAccountService;
        }

        [HttpPost("payment")]
        public async Task<IActionResult> Payment(TransactionViewModel transaction)
        {
            var currentAccount = _currentAccountService.ProcessYield(_user.GetUserId());
            var
            return CustomResponse(await _currentAccountService.Pay());
        }

        [HttpPost("deposit")]
        public async Task<IActionResult> Deposit()
        {
            var pedido = await _pedidoQueries.ObterUltimoPedido(_user.GetUserId());

            return pedido == null ? NotFound() : CustomResponse(pedido);
        }

        [HttpPost("withdrawal")]
        public async Task<IActionResult> Withdrawal()
        {
            var pedidos = await _pedidoQueries.ObterListaPorClienteId(_user.ObterUserId());

            return pedidos == null ? NotFound() : CustomResponse(pedidos);
        }
    }
}