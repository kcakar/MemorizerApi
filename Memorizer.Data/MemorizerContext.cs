using Memorizer.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Memorizer.Data
{
    public sealed class MemorizerContext : DbContext
    {
        public MemorizerContext(DbContextOptions options) : base(options)
        {
            //Database.Migrate();
        }

        //
        // Summary:
        //     Override this method to further configure the model that was discovered by convention
        //     from the entity types exposed in Microsoft.EntityFrameworkCore.DbSet`1 properties
        //     on your derived context. The resulting model may be cached and re-used for subsequent
        //     instances of your derived context.
        //
        // Parameters:
        //   modelBuilder:
        //     The builder being used to construct the model for this context. Databases (and
        //     other extensions) typically define extension methods on this object that allow
        //     you to configure aspects of the model that are specific to a given database.
        //
        // Remarks:
        //     If a model is explicitly set on the options for this context (via Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel))
        //     then this method will not be run.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u=>u.DateCreated)
                .HasComputedColumnSql("GetUtcDate()");
        }

        public DbSet<Language> Languages { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Workset> Worksets { get; set; }
    }
}
