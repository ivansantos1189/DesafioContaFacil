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

        private readonly IAspNetUser _user;
        private readonly ICurrentAccountService _currentAccountService;

        public CurrentAccountController(IAspNetUser user, ICurrentAccountService currentAccountService)
        {
            _user = user;
            _currentAccountService = currentAccountService;
        }

        [HttpGet]
        public async Task<IActionResult> CreateAccount()
        {
            //var currentAccount = await _currentAccountService.GetByCustomerId(_user.GetUserId());
            return CustomResponse(await _currentAccountService.Create(_user.GetUserId()));
        }

        [HttpPost("payment")]
        public async Task<IActionResult> Payment(TransactionViewModel transaction)
        {
            var currentAccount = await _currentAccountService.GetByCustomerId(_user.GetUserId());
            return CustomResponse(await _currentAccountService.Pay(currentAccount, transaction.Amount));
        }

        [HttpPost("deposit")]
        public async Task<IActionResult> Deposit(TransactionViewModel transaction)
        {
            var currentAccount = await _currentAccountService.GetByCustomerId(_user.GetUserId());
            return CustomResponse(await _currentAccountService.Deposit(currentAccount, transaction.Amount));
        }

        [HttpPost("withdrawal")]
        public async Task<IActionResult> Withdrawal(TransactionViewModel transaction)
        {
            var currentAccount = await _currentAccountService.GetByCustomerId(_user.GetUserId());
            return CustomResponse(await _currentAccountService.ToWithdraw(currentAccount, transaction.Amount));
        }
    }
}