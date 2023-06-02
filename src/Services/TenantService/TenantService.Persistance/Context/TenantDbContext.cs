using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Domain.Entities;

namespace TenantService.Persistance.Context
{
    public class TenantDbContext:DbContext
    {

        private readonly IConfiguration _configuration;
        public DbSet<Tenant> Tenants { get; set; }
        public TenantDbContext()
        {

        }

        public TenantDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
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
            modelBuilder.Entity<Tenant>().HasQueryFilter(b => !b.IsDeleted);

            modelBuilder.Entity<Tenant>(a =>
            {
                a.ToTable("Tenants").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.DeletedTime).HasColumnName("DeletedTime");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.IsDeleted).HasColumnName("IsDeleted");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.EmailAddress).HasColumnName("EmailAddress");
            });



            Tenant[] tenantEntitySeeds = {
                new(1, "admin","admin" ,1,DateTime.Now,DateTime.Now.AddDays(10), "admin@outlook.com",DateTime.Now,null,false),

                new(2, "default","default" ,2,DateTime.Now,DateTime.Now.AddDays(10), "default@outlook.com",DateTime.Now,null,false),


                new(3, "bora","cetin" ,1,DateTime.Now,DateTime.Now.AddDays(10), "default@outlook.com",DateTime.Now,null,false),

                new(4, "pinar","uyar" ,3,DateTime.Now,DateTime.Now.AddDays(20), "pinar@outlook.com",DateTime.Now,null,true)


            };
            modelBuilder.Entity<Tenant>().HasData(tenantEntitySeeds);


        }
    }
}
