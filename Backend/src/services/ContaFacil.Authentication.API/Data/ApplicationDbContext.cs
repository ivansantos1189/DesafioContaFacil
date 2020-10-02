using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ContaFacil.Authentication.API.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>(entity => entity.Property(m => m.Id).HasMaxLength(127));
            builder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(127));
            builder.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(127));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(127));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(127));
            builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(127));
            builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(127));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(127));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(127));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(127));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(127));
        }
    }


}
