using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PaymentService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentService.Persistance.Context
{
    public class PaymentDbContext:DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Payment> Payments { get; set; }
        public PaymentDbContext()
        {

        }

        public PaymentDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
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
            modelBuilder.Entity<Payment>().HasQueryFilter(b => !b.IsDeleted);

            modelBuilder.Entity<Payment>(a =>
            {
                a.ToTable("Payments").HasKey(k => k.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.DeletedTime).HasColumnName("DeletedTime");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.CreatedTime).HasColumnName("CreatedTime");
                a.Property(p => p.IsDeleted).HasColumnName("IsDeleted");
                a.Property(p => p.TenantId).HasColumnName("TenantId");
                a.Property(p => p.SuccessUrl).HasColumnName("SuccessUrl");
                a.Property(p => p.ErrorUrl).HasColumnName("ErrorUrl");
                a.Property(p => p.Amount).HasColumnName("Amount");
                a.Property(p => p.PaymentStatus).HasColumnName("PaymentStatus");




            });
            Payment[] paymentEntitySeeds = {
                new(1,1,"www.boracetin.com/successUrl","www.deneme.com/erroUrl",10,PaymentStatusEnum.Completed,DateTime.UtcNow,null,false),
                new(2,1,"www.admin.com/successUrl","www.deneme.com/erroUrl",20,PaymentStatusEnum.Failed,DateTime.UtcNow,null,false),

                new(3,1,"www.pinar.com/successUrl","www.deneme.com/erroUrl",30,PaymentStatusEnum.Paid,DateTime.UtcNow,null,false),
                new(4,1,"www.selma.com/successUrl","www.deneme.com/erroUrl",40,PaymentStatusEnum.Canceled,DateTime.UtcNow,null,false),








            };

            modelBuilder.Entity<Payment>().HasData(paymentEntitySeeds);

        }
    }
}