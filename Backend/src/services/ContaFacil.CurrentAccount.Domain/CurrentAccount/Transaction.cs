using System;
using ContaFacil.Core.DomainObjects;

namespace ContaFacil.CurrentAccount.Domain
{
    public class Transaction : Entity, IAggregateRoot
    {
        public Transaction(Guid currentAccountId, TransactionType transactionType, decimal amount)
        {
            CurrentAccountId = currentAccountId;
            TransactionType = transactionType;
            Amount = amount;
            TransactionDate = new DateTime();
        }

        protected Transaction() { }

        public Guid CurrentAccountId { get; private set; }
        public TransactionType TransactionType { get; private set; }
        public decimal Amount { get; private set; }

        public DateTime TransactionDate { get; private set; }

    }
}
