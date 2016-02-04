using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Intro.Model;

namespace TDD.Infrastructure.DataAccess.EntityFramework
{
    public class TddDbContext : DbContext
    {
        public TddDbContext(string connectionStringName)
            : base(connectionStringName)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                        .HasKey(p => p.Id);
            modelBuilder.Entity<Person>().HasMany(p => p.Addresses).WithOptional().WillCascadeOnDelete(true);
            modelBuilder.Entity<Person>().MapToStoredProcedures();

            modelBuilder.Entity<Physical>().Property(f => f.BornDate).HasColumnType("datetime2");
            modelBuilder.Entity<Physical>().MapToStoredProcedures();
            
            modelBuilder.Entity<Company>().MapToStoredProcedures();

            modelBuilder.Entity<Address>()
                        .HasKey(p => p.Id);
            modelBuilder.Entity<Address>().MapToStoredProcedures();
        }
    }
}