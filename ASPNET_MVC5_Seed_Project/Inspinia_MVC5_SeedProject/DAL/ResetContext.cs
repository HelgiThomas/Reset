using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inspinia_MVC5_SeedProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Inspinia_MVC5_SeedProject.DAL
{
    public class ResetContext: DbContext
    {
        // The name of the connection string (which you'll add to the Web.config file later)
        // is passed in to the constructor.
        public ResetContext() : base("ResetContext")
        {

        }

        // This code creates a DbSet property for each entity set. 
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet <Measurement> Measurements { get; set; }
        public DbSet <Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}