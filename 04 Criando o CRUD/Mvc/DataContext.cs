namespace Mvc
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext() : base("name=DataContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Contato>().ToTable("Contatos");
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
