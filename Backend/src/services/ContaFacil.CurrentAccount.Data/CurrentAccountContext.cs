using Microsoft.EntityFrameworkCore;
using ContaFacil.Core.Data;
using ContaFacil.Core.DomainObjects;
using ContaFacil.CurrentAccount.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ContaFacil.CurrentAccount.Data
{
    public class CurrentAccountContext : DbContext, IUnitOfWork
    {

        public CurrentAccountContext(DbContextOptions<CurrentAccountContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.CurrentAccount> CurrentAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        public async Task<bool> Commit()
        {

            var sucesso = await base.SaveChangesAsync() > 0;

            return sucesso;
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
        //        e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
        //        property.Relational().ColumnType = "varchar(100)";

        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(CurrentAccountContext).Assembly);

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
