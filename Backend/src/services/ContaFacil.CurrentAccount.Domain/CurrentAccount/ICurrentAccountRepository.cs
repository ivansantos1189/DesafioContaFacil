using ContaFacil.Core.Data;
using System;

namespace ContaFacil.CurrentAccount.Domain
{
    public interface ICurrentAccountRepository : IRepository<CurrentAccount>
    {
        void Create(CurrentAccount currentAccount);
        void Update(CurrentAccount currentAccount);

        CurrentAccount GetByCustomerId(Guid customerId);

        void CreateTransaction(Transaction transaction);

    }
}
