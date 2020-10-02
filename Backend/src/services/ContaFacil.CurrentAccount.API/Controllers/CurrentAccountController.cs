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
    [Route("api/CurrentAccount")]
    public class CurrentAccountController : MainController
    {

        private readonly AspNetUser _user;
        private readonly ICurrentAccountService _currentAccountService;

        public CurrentAccountController(AspNetUser user, ICurrentAccountService currentAccountService)
        {
            _user = user;
            _currentAccountService = currentAccountService;
        }

        [HttpPost("payment")]
        public async Task<IActionResult> Payment(TransactionViewModel transaction)
        {
            var currentAccount = _currentAccountService.GetByCustomerId(_user.GetUserId());
            return CustomResponse(await _currentAccountService.Pay(currentAccount, transaction.Amount));
        }

        [HttpPost("deposit")]
        public async Task<IActionResult> Deposit(TransactionViewModel transaction)
        {
            var currentAccount = _currentAccountService.GetByCustomerId(_user.GetUserId());
            return CustomResponse(await _currentAccountService.Deposit(currentAccount, transaction.Amount));
        }

        [HttpPost("withdrawal")]
        public async Task<IActionResult> Withdrawal(TransactionViewModel transaction)
        {
            var currentAccount = _currentAccountService.GetByCustomerId(_user.GetUserId());
            return CustomResponse(await _currentAccountService.ToWithdraw(currentAccount, transaction.Amount));
        }
    }
}