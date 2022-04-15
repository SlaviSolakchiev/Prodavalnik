namespace Prodavalnik.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Prodavalnik.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.AddAsync(new Category { Name = "Електроника", IsDeleted = false });
            await dbContext.AddAsync(new Category { Name = "Животни", IsDeleted = false });
            await dbContext.AddAsync(new Category { Name = "Мода", IsDeleted = false });
            await dbContext.AddAsync(new Category { Name = "Дом и градина", IsDeleted = false });
            await dbContext.SaveChangesAsync();
        }
    }

}
