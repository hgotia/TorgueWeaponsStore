using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Pistols.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Hand Cannon",
                        Description = "Did you see the size of that gun he fired at us? It was bigger than him.",
                        Category = "Common",
                        Price = 1000
                    },
                    new Product
                    { 
                        Name = "Hole Puncher",
                        Description = "Excuse me, I believe you have my stapler...",
                        Category = "Common",
                        Price = 1000
                    },
                    new Product
                    {
                        Name = "Injector",
                        Description = "Just hold still. This will only take a moment.",
                        Category = "Common",
                        Price = 1000
                    },
                    new Product
                    {
                        Name = "Rod",
                        Description = "Insert something here",    
                        Category = "Common",
                        Price = 1000
                    },
                    new Product
                    {
                        Name = "Slapper",
                        Description = "Slap 'dat ass, son",
                        Category = "Common",
                        Price = 1000
                    },
                    new Product
                    {
                        Name = "Pocket Rocket",
                        Description = "Did you ever have the feeling",
                        Category = "Unique",
                        Price = 2500
                    },
                    new Product
                    {
                        Name = "Unkempt Harold",
                        Description = "Did I fire six shots, or only five? Three? Seven. Whatever.",
                        Category = "Legendary",
                        Price = 7500
                    },
                    new Product
                    {
                        Name = "Devastator",
                        Description = "Hail - Increased damage and fires a two-round burst. Decreased bullet velocity.",
                        Category = "Seraph",
                        Price = 15000
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}