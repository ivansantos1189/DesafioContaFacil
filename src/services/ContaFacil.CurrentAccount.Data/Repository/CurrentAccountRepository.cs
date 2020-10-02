using System;
using ContaFacil.Core.Data;
using ContaFacil.CurrentAccount.Domain;

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
            throw new NotImplementedException();
        }

        public void CreateTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Domain.CurrentAccount GetByCustomerId(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.CurrentAccount currentAccount)
        {
            throw new NotImplementedException();
        }
    }
}