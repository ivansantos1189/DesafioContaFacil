﻿using ContaFacil.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContaFacil.CurrentAccount.Domain
{
    public interface ICurrentAccountRepository : IRepository<CurrentAccount>
    {
        void Create(CurrentAccount currentAccount);
        void Update(CurrentAccount currentAccount);

        Task<CurrentAccount> GetByCustomerId(Guid customerId);

        void CreateTransaction(Transaction transaction);
        Task<List<Transaction>> GetListTransactions(Guid currentAccountId);
    }
}
