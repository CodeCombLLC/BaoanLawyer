using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BaoanLawyer.Models
{
    public class LawyerContext : IdentityDbContext<User, IdentityRole, string>
    {
        public DbSet<Lawyer> Lawyers { get; set; }

        public DbSet<Case> Cases { get; set; }

        public DbSet<LawyerCase> LawyerCases { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Catalog> Catalogs { get; set; }

        public DbSet<Information> Informations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Lawyer>(e => 
            {
                e.HasIndex(x => x.PRI);
                e.HasIndex(x => x.Name);
            });

            builder.Entity<Case>(e =>
            {
                e.HasIndex(x => x.Time);
                e.HasIndex(x => x.Type);
                e.HasIndex(x => x.Title);
                e.HasIndex(x => x.Private);
            });

            builder.Entity<LawyerCase>(e => 
            {
                e.HasKey(x => new { x.LawyerId, x.CaseId });
            });

            builder.Entity<Catalog>(e => 
            {
                e.HasIndex(x => x.PRI);
            });

            builder.Entity<Information>(e => 
            {
                e.HasIndex(x => x.Time);
                e.HasIndex(x => x.Title);
            });
        }
    }
}
