using System;
using System.Collections.Generic;
using System.Data.Entity;
using Jo2me.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Jo2me.Data
{
    public class PropertyDbInitializer : CreateDatabaseIfNotExists<StageDbContext>
    {
        protected override void Seed(StageDbContext context)
        {
            SeedUser(context);
            SeedLocationAndStage(context);
            base.Seed(context);
        }

        private static void SeedUser(StageDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            userManager.UserValidator = new UserValidator<ApplicationUser>(userManager)
            {
                AllowOnlyAlphanumericUserNames = false
            };
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }

            if (!roleManager.RoleExists("User"))
            {
                roleManager.Create(new IdentityRole("User"));
            }

            var user = new ApplicationUser
            {
                FirstName = "Admin",
                LastName = "Jose",
                Email = "admin@joisys.com",
                UserName = "admin@joisys.com"
            };

            var userResult = userManager.Create(user, "Password");

            if (userResult.Succeeded)
            {
                userManager.AddToRole(user.Id, "Admin");
            }


        }

        private static void SeedLocationAndStage(StageDbContext context)
        {
            List<Location> locationsList = new List<Location>();
            for (int i = 0; i < 5; i++)
            {
                Location location = new Location
                {
                    Name = "Location " + i,
                    Properties = new List<Stage>()
                };


                int noOfProperties = new Random().Next(1, 10);
                for (int j = 0; j < noOfProperties; j++)
                {
                    location.Properties.Add(new Stage
                    {
                        Title = "Stage Title ",
                        Description = "Stage Description",
                        Location = location
                    });
                }
                locationsList.Add(location);
            }
            context.Locations.AddRange(locationsList);
        }
    }
}