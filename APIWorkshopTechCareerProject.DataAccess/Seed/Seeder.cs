using APIWorkshopTechCareerProject.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography;
using System.Text;

namespace APIWorkshopTechCareerProject.DataAccess.Seed
{
    public class Seeder
    {
        public async Task SeedAsync(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<Data.TechCareerDbContext>();

                #region Add User

                if (db.Users.Any() is false)
                {
                    db.Users.Add(new Models.Models.User()
                    {
                        UserName = "EsinDerya",
                        Password = "derya123"
                    });

                    await db.SaveChangesAsync();
                }

                #endregion

                await db.Database.MigrateAsync();

            }
        }

    }
}
