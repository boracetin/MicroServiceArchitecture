using EditionService.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EditionService.Persistance.Context
{
    public class BaseDbContext:DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<EditionInfo> Editions { get; set; }
        public BaseDbContext()
        {

        }

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            _configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                base.OnConfiguring(
                    optionsBuilder.UseSqlServer("Data Source=host.docker.internal,1433; Initial Catalog=MicroServiceTestDb; Persist Security Info=True; User ID=sa; Password=boracetin123!; TrustServerCertificate=True; MultipleActiveResultSets=True",
                     options => options.EnableRetryOnFailure()));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EditionInfo>().HasQueryFilter(b => !b.IsDeleted);

            modelBuilder.Entity<EditionInfo>(a =>
            {
                a.ToTable("Editions").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.DeletedTime).HasColumnName("DeletedTime");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.IsDeleted).HasColumnName("IsDeleted");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Price).HasColumnName("Price");
                a.Property(p => p.TrialDay).HasColumnName("TrialDay");

            });
            EditionInfo[] editionInfoSeeds =
            {
                 new(1, "standart",20 ,1,DateTime.Now,null,false),
                 new(2, "admin",15 ,1,DateTime.Now,null,false),

            };
            modelBuilder.Entity<EditionInfo>().HasData(editionInfoSeeds);



        }
    }
}
