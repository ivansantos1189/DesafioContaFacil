using System;
using System.Threading.Tasks;

namespace ContaFacil.CurrentAccount.Domain
{
    public interface ICurrentAccountService
    {
        Task<CurrentAccount> Create(Guid customerId);

        Task<Transaction> Pay(CurrentAccount currentAccount, decimal amount);

        Task<Transaction> Deposit(CurrentAccount currentAccount, decimal amount);

        Task<Transaction> ToWithdraw(CurrentAccount currentAccount, decimal amount);

        Task ProcessYield(CurrentAccount currentAccount);
    }
}

