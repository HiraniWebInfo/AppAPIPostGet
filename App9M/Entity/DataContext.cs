using App9M.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace App9M.Entity
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<tblSettings>()
                .HasData(
                new tblSettings
                {
                    Id = 1,
                    Name = "BaseUrl",
                    Description = "",
                },
                new tblSettings
                {
                    Id = 2,
                    Name = "LoginReqType",
                    Description = "",
                },
                new tblSettings
                {
                    Id = 3,
                    Name = "LoginUrl",
                    Description = "",
                },
                new tblSettings
                {
                    Id = 4,
                    Name = "LoginReqJson",
                    Description = "",
                },
                new tblSettings
                {
                    Id = 5,
                    Name = "LoginRespJson",
                    Description = "",
                }
                );
            modelBuilder.Entity<tblUrlList>()
                .HasIndex(e => e.Name)
                .IsUnique();
            modelBuilder.Entity<tblSettings>()
                .HasIndex(ex => ex.Name)
                .IsUnique();
            modelBuilder.Entity<tblParameters>()
                .HasIndex(p => new { p.urlId, p.Name })
                .IsUnique();
            modelBuilder.Entity<tblHeaders>()
                .HasIndex(h => new { h.urlId, h.HeaderKey })
                .IsUnique();
        }
        public DbSet<tblSettings> tblSettings { get; set; }
        public DbSet<tblUrlList> tblUrlList { get; set; }
        public DbSet<tblParameters> tblParameters { get; set; }
        public DbSet<tblHeaders> tblHeaders { get; set; }
    }
}
