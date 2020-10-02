using System;
using System.Threading.Tasks;
using ContaFacil.Core.Data;
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

        public void CreateTransaction(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
        }

        public async Task<Domain.CurrentAccount> GetByCustomerId(Guid customerId)
        {
            return await _context.CurrentAccounts.FirstOrDefaultAsync(c => c.CustomerId == customerId);
        }

        public void Update(Domain.CurrentAccount currentAccount)
        {
            _context.CurrentAccounts.Update(currentAccount);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}