using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HealthCatalystApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using static HealthCatalystApp.Models.PeopleModel;

namespace HealthCatalystApp.DAL
{
    /// <summary>
    /// Data Access Layer for Health Catalyst App
    /// </summary>
    public class PeopleContext : DbContext
    {
        public PeopleContext() : base("PeopleContext")
        {
        }

        public DbSet<People> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}