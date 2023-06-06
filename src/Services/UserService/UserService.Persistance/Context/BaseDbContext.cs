using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using UserService.Domain;

namespace UserService.Persistance.Context
{
    public class BaseDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<User> Editions { get; set; }
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
            modelBuilder.Entity<User>().HasQueryFilter(b => !b.IsDeleted);

            modelBuilder.Entity<User>(a => 
            {
                a.ToTable("Users").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.DeletedTime).HasColumnName("DeletedTime");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.IsDeleted).HasColumnName("IsDeleted");
                a.Property(p => p.Name).HasColumnName("Name");
                a.Property(p => p.Surname).HasColumnName("Surname");
                a.Property(p => p.EmailAddress).HasColumnName("EmailAddress");
                a.Property(p => p.TenantId).HasColumnName("TenantId");




            });
            
            User[] userSeeds =
            {
                 new(1,"bora","cetin","bora@hotmail.com",1,DateTime.Now,null,false),
                new(2,"pinar","cetin","pinar@hotmail.com",3,DateTime.Now,null,false),


            };
            modelBuilder.Entity<User>().HasData(userSeeds);



        }
    }
}
