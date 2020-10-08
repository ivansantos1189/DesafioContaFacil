using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ContaFacil.Core.WebAPI;
using ContaFacil.WebAPI.Core.User;
using ContaFacil.CurrentAccount.API.Models;
using ContaFacil.CurrentAccount.Domain;
using ContaFacil.Core.DomainObjects;

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

        [HttpPost]
        public async Task<IActionResult> CreateAccount()
        {
            return CustomResponse(await _currentAccountService.Create(_user.GetUserId()));
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentAccount()
        {
            return CustomResponse(await _currentAccountService.GetByCustomerId(_user.GetUserId()));
        }

        [HttpPost("payment")]
        public async Task<IActionResult> Payment(TransactionViewModel transaction)
        {
            try
            {
                var currentAccount = await _currentAccountService.GetByCustomerId(_user.GetUserId());
                return CustomResponse(await _currentAccountService.Pay(currentAccount, transaction.Amount));
            }
            catch (DomainException ex)
            {
                AddError(ex.Message);
                return CustomResponse();
            }
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
            try
            {
                var currentAccount = await _currentAccountService.GetByCustomerId(_user.GetUserId());
                return CustomResponse(await _currentAccountService.ToWithdraw(currentAccount, transaction.Amount));
            }
            catch (DomainException ex)
            {
                AddError(ex.Message);
                return CustomResponse();
            }

        }

        [HttpGet("transaction_list")]
        public async Task<IActionResult> GetListTransactions()
        {
            var currentAccount = await _currentAccountService.GetByCustomerId(_user.GetUserId());
            return CustomResponse(await _currentAccountService.GetListTransaction(currentAccount));
        }
    }
}