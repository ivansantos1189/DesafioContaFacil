using ContaFacil.CurrentAccount.Domain;
using Moq.AutoMock;
using System;
using Xunit;

namespace ContaFacil.Business.Test
{
    [CollectionDefinition(nameof(CurrentAccountMockerColection))]

    public class CurrentAccountMockerColection : ICollectionFixture<CurrentAccountTestsFixure>
    {
    }

    public class CurrentAccountTestsFixure : IDisposable
    {
        public CurrentAccountService currentAccountService;
        public AutoMocker Mocker;

        public CurrentAccountService GetCurrentAccountService()
        {
            Mocker = new AutoMocker();
            currentAccountService = Mocker.CreateInstance<CurrentAccountService>();

            return currentAccountService;
        }

        public CurrentAccount.Domain.CurrentAccount GenerateCurrentAccountValid()
        {
            return new CurrentAccount.Domain.CurrentAccount(Guid.NewGuid());
        }

        public void Dispose()
        {
        }
    }



}
