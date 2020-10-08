using ContaFacil.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContaFacil.CurrentAccount.Domain
{
    public class CurrentAccountService : ICurrentAccountService
    {
        private readonly ICurrentAccountRepository _currentAccountRepository;
        private readonly double TaxCDI = 0.025;

        public CurrentAccountService(ICurrentAccountRepository currentAccountRepository)
        {
            _currentAccountRepository = currentAccountRepository;
        }

        public async Task<CurrentAccount> Create(Guid customerId)
        {
            var currentAccount = new CurrentAccount(customerId);

            _currentAccountRepository.Create(currentAccount);

            await _currentAccountRepository.UnitOfWork.Commit();

            return currentAccount;
        }

        public async Task<CurrentAccount> GetByCustomerId(Guid customerId)
        {
            return await _currentAccountRepository.GetByCustomerId(customerId);
        }

        public async Task<Transaction> Deposit(CurrentAccount currentAccount, decimal amount)
        {
            var transaction = new Transaction(currentAccount.Id, TransactionType.Deposit, amount);

            _currentAccountRepository.CreateTransaction(transaction);

            currentAccount.CurrentBalance += amount;

            _currentAccountRepository.Update(currentAccount);

            await _currentAccountRepository.UnitOfWork.Commit();

            return transaction;
        }

        public async Task<Transaction> Pay(CurrentAccount currentAccount, decimal amount)
        {
            if (amount > currentAccount.CurrentBalance)
                throw new DomainException("Saldo insuficiente!");

            var transaction = new Transaction(currentAccount.Id, TransactionType.Payment, amount);

            _currentAccountRepository.CreateTransaction(transaction);

            currentAccount.CurrentBalance -= amount;

            _currentAccountRepository.Update(currentAccount);

            await _currentAccountRepository.UnitOfWork.Commit();

            return transaction;
        }

        public async Task ProcessYield(CurrentAccount currentAccount)
        {
            var yield = Math.Round((currentAccount.CurrentBalance * (decimal)TaxCDI), 2);

            var transaction = new Transaction(currentAccount.Id, TransactionType.Yield, yield);

            _currentAccountRepository.CreateTransaction(transaction);

            currentAccount.CurrentBalance += yield;

            _currentAccountRepository.Update(currentAccount);

            await _currentAccountRepository.UnitOfWork.Commit();
        }

        public async Task<Transaction> ToWithdraw(CurrentAccount currentAccount, decimal amount)
        {
            if (amount > currentAccount.CurrentBalance)
                throw new DomainException("Saldo insuficiente!");

            var transaction = new Transaction(currentAccount.Id, TransactionType.Withdrawal, amount);

            _currentAccountRepository.CreateTransaction(transaction);

            currentAccount.CurrentBalance -= amount;

            _currentAccountRepository.Update(currentAccount);

            await _currentAccountRepository.UnitOfWork.Commit();

            return transaction;
        }

        public async Task<List<Transaction>> GetListTransaction(CurrentAccount currentAccount)
        {
            return await _currentAccountRepository.GetListTransactions(currentAccount.Id);
        }
    }
}