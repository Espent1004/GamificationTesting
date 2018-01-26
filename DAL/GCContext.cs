using Model.DBModels;
using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics.CodeAnalysis;
using System.Linq;


namespace DAL
{
    public class GCContext : DbContext
    {
        public GCContext() : base("name=GCDatabase")
        {
            Database.SetInitializer(new DbInit());

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonGameStats> PersonGameStats { get; set; }
        public DbSet<Level> Levels { get; set; }
        //public DbSet<DBCategory> Categories { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}