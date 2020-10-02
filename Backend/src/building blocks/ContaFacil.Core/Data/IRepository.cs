using System;
using ContaFacil.Core.DomainObjects;

namespace ContaFacil.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}