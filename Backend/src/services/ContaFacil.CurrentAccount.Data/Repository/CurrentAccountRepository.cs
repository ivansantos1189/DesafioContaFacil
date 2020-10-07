using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContaFacil.Core.Data;
using System.Linq;
using ContaFacil.CurrentAccount.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContaFacil.CurrentAccount.Data.Repository
{
    public class CurrentAccountRepository : ICurrentAccountRepository
    {
        private readonly CurrentAccountContext _context;

        public CurrentAccountRepository(CurrentAccountContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Create(Domain.CurrentAccount currentAccount)
        {
            _context.CurrentAccounts.Add(currentAccount);
        }
        public async Task<Domain.CurrentAccount> GetByCustomerId(Guid customerId)
        {
            return await _context.CurrentAccounts.FirstOrDefaultAsync(c => c.CustomerId == customerId);
        }

        public void Update(Domain.CurrentAccount currentAccount)
        {
            _context.CurrentAccounts.Update(currentAccount);
        }

        public void CreateTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
        }

        public async Task<List<Transaction>> GetListTransactions(Guid currentAccountId)
        {
            return await _context.Transactions
                    .AsNoTracking()
                    .Where(t => t.CurrentAccountId == currentAccountId && t.TransactionType != TransactionType.Yield)
                    .OrderByDescending(t => t.TransactionDate)
                    .ToListAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}