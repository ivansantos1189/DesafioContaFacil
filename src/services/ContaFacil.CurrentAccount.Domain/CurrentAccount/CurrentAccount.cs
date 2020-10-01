using System;
using ContaFacil.Core.DomainObjects;

namespace ContaFacil.CurrentAccount.Domain
{
    public class CurrentAccount : Entity, IAggregateRoot
    {
        private readonly Random _random = new Random();

        public CurrentAccount(Guid customerId)
        {
            CustomerId = customerId;
            AccountNumber = _random.Next(900000, 999999);
        }

        protected CurrentAccount() { }

        public int AccountNumber { get; set; }
        public Guid CustomerId { get; set; }
        public decimal CurrentBalance { get; set; }

    }
}
