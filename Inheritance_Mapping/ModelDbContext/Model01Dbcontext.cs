using Inheritance_Mapping.Q2;
using Inheritance_Mapping.Q3;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Mapping.ModelDbContext
{
    internal class Model01Dbcontext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Inheritance Mapping ;Integrated Security=True;TrustServerCertificate=True");
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Q2
            modelBuilder.Entity<CashPayment>().HasBaseType<Payment>();
            modelBuilder.Entity<CreditCardPayment>().HasBaseType<Payment>();
            #endregion

            #region Q3
            modelBuilder.Entity<Book>().ToTable("Books Table");
            modelBuilder.Entity<Electronics>().ToTable("Electronics Table");





            #endregion

        }

        #region Q1
        DbSet<Vehicle> Vehicles { get; set; }

        #endregion

        #region q2
        DbSet<CashPayment> cashPayments { get; set; }
        DbSet<CreditCardPayment> creditCardPayments { get; set; }
        DbSet<Payment> payments { get; set; }
        #endregion

        #region Q3

        DbSet<Book>books { get; set; }
         DbSet<Electronics> electronics { get; set; }


        #endregion


    }
}