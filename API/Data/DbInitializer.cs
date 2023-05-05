using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    UserName = "kevin",
                    Email = "kevin@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user,"Member");

                var admin = new User
                {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] {"Member", "Admin"});
            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                        new Product
                {
                    Prod_name = "Angular Speedster Board 2000",
                    Prod_desc =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    Prod_pics = "/images/products/sb-ang1.png",
                    Brand = "Angular",
                    Prod_type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Green Angular Board 3000",
                    Prod_desc = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    Prod_pics = "/images/products/sb-ang2.png",
                    Brand = "Angular",
                    Prod_type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Core Board Speed Rush 3",
                    Prod_desc =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    Prod_pics = "/images/products/sb-core1.png",
                    Brand = "NetCore",
                    Prod_type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Net Core Super Board",
                    Prod_desc =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    Prod_pics = "/images/products/sb-core2.png",
                    Brand = "NetCore",
                    Prod_type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "React Board Super Whizzy Fast",
                    Prod_desc =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    Prod_pics = "/images/products/sb-react1.png",
                    Brand = "React",
                    Prod_type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Prod_typescript Entry Board",
                    Prod_desc =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    Prod_pics = "/images/products/sb-ts1.png",
                    Brand = "Prod_typeScript",
                    Prod_type = "Boards",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Core Blue Hat",
                    Prod_desc =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    Prod_pics = "/images/products/hat-core1.png",
                    Brand = "NetCore",
                    Prod_type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Green React Woolen Hat",
                    Prod_desc =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    Prod_pics = "/images/products/hat-react1.png",
                    Brand = "React",
                    Prod_type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Purple React Woolen Hat",
                    Prod_desc =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    Prod_pics = "/images/products/hat-react2.png",
                    Brand = "React",
                    Prod_type = "Hats",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Blue Code Gloves",
                    Prod_desc =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    Prod_pics = "/images/products/glove-code1.png",
                    Brand = "VS Code",
                    Prod_type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Green Code Gloves",
                    Prod_desc =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    Prod_pics = "/images/products/glove-code2.png",
                    Brand = "VS Code",
                    Prod_type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Purple React Gloves",
                    Prod_desc =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    Prod_pics = "/images/products/glove-react1.png",
                    Brand = "React",
                    Prod_type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Green React Gloves",
                    Prod_desc =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    Prod_pics = "/images/products/glove-react2.png",
                    Brand = "React",
                    Prod_type = "Gloves",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Redis Red Boots",
                    Prod_desc =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    Prod_pics = "/images/products/boot-redis1.png",
                    Brand = "Redis",
                    Prod_type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Core Red Boots",
                    Prod_desc =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    Prod_pics = "/images/products/boot-core2.png",
                    Brand = "NetCore",
                    Prod_type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Core Purple Boots",
                    Prod_desc =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    Prod_pics = "/images/products/boot-core1.png",
                    Brand = "NetCore",
                    Prod_type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Angular Purple Boots",
                    Prod_desc = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    Prod_pics = "/images/products/boot-ang2.png",
                    Brand = "Angular",
                    Prod_type = "Boots",
                    QuantityInStock = 100
                },
                new Product
                {
                    Prod_name = "Angular Blue Boots",
                    Prod_desc =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    Prod_pics = "/images/products/boot-ang1.png",
                    Brand = "Angular",
                    Prod_type = "Boots",
                    QuantityInStock = 100
                },
            };

            //context.Products.AddRange(products);

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}