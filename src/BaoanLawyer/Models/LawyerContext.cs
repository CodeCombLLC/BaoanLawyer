using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using CodeComb.AspNet.Upload.Models;

namespace BaoanLawyer.Models
{
    public class LawyerContext : IdentityDbContext<User, IdentityRole, string>, IFileUploadDbContext
    {
        public DbSet<Lawyer> Lawyers { get; set; }

        public DbSet<Case> Cases { get; set; }

        public DbSet<LawyerCase> LawyerCases { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Catalog> Catalogs { get; set; }

        public DbSet<Information> Informations { get; set; }

        public DbSet<File> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.SetupBlob();

            builder.Entity<Lawyer>(e => 
            {
                e.HasIndex(x => x.PRI);
                e.HasIndex(x => x.Name);
                e.HasIndex(x => x.BannerId);
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
                e.HasIndex(x => x.Hide);
            });

            builder.Entity<Information>(e => 
            {
                e.HasIndex(x => x.Time);
                e.HasIndex(x => x.Title);
                e.HasIndex(x => x.Top);
            });
        }
    }
}
