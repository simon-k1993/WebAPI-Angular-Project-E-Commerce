using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheShop.Domain.Entities.Identity;

namespace TheShop.DataAccess.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAasync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Freddie",
                    Email = "freddie@test.com",
                    UserName = "freddie@test.com",
                    Address = new Address
                    {
                        FirstName = "Freddie",
                        LastName = "TheDog",
                        Street = "10 The Dog Street",
                        City = "Dog City",
                        State = "DC",
                        Zipcode = "10101"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
