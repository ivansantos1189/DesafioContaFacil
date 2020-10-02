//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using ContaFacil.CurrentAccount.Domain;

//namespace ContaFacil.CurrentAccount.Data.Mappings
//{
//    public class CurrentAccountMapping : IEntityTypeConfiguration<Domain.CurrentAccount>
//    {
//        //public void Configure(EntityTypeBuilder<Domain.CurrentAccount> builder)
//        //{

//        //    builder.HasKey(c => c.Id);

//        //    builder.Property(c => c.AccountNumber)
//        //        .IsRequired()
//        //        .HasColumnType("int");

//        //    // 1 : N => Categorias : Produtos
//        //    builder.HasMany(c => c.Produtos)
//        //        .WithOne(p => p.Categoria)
//        //        .HasForeignKey(p => p.CategoriaId);

//        //    builder.ToTable("Categorias");
//        //}
//    }
//}