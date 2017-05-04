using System.Data.Entity;
using Jo2me.Data.Configurations;
using Jo2me.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Jo2me.Data
{
    public class StageDbContext : IdentityDbContext<ApplicationUser>
    {
        public StageDbContext() : base("StageDbContext")
        {
            Database.SetInitializer(new PropertyDbInitializer());
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Stage> Properties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new StageConfiguration());

            //Configurations Auto generated tables for IdentityDbContext.
            modelBuilder.Configurations.Add(new IdentityUserRoleConfiguration());
            modelBuilder.Configurations.Add(new IdentityUserLoginConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}