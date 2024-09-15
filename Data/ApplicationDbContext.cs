using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace YumBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
       public DbSet<Category> Category { get; set; }
       public DbSet<Product> Product { get; set; }
		public DbSet<ShoppingCart> ShoppingCart { get; set; }

        public DbSet<OrderHeader> OrderHeader { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(

                new Category() { Id = 1, Name = "Appetizer" },
                new Category() { Id = 2, Name = "Entree" },
                new Category() { Id = 3, Name = "Dessert" }
                );
            builder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Spring Rolls",
                        Price = 5.99M,
                        Description = "Crispy vegetable spring rolls with a tangy dipping sauce.",
                        SpecialTag = "Starter",
                        CategoryId = 1,
                        ImageUrl = "/images/product/spring_rolls.jpg"
                    },
    new Product
    {
        Id = 2,
        Name = "Caesar Salad",
        Price = 8.99M,
        Description = "Classic Caesar salad with croutons, parmesan, and Caesar dressing.",
        SpecialTag = "Healthy",
        CategoryId = 1,
        ImageUrl = "/images/product/caesar_salad.jpg"
    },
    new Product
    {
        Id = 3,
        Name = "Grilled Chicken",
        Price = 15.99M,
        Description = "Juicy grilled chicken breast served with a side of vegetables.",
        SpecialTag = "Popular",
        CategoryId = 2,
        ImageUrl = "/images/product/grilled_chicken.jpg"

    },
    new Product
    {
        Id = 4,
        Name = "Beef Burger",
        Price = 12.99M,
        Description = "Beef burger with cheese, lettuce, tomato, and a side of fries.",
        SpecialTag = "Best Seller",
        CategoryId = 2,
        ImageUrl = "/images/product/Double-beef-burger.png"
    },
    new Product
    {
        Id = 5,
        Name = "Chocolate Cake",
        Price = 6.99M,
        Description = "Rich chocolate cake with a creamy ganache filling.",
        SpecialTag = "Dessert",
        CategoryId = 3,
        ImageUrl = "/images/product/chocolate_cake.jpg"
    },
    new Product
    {
        Id = 6,
        Name = "Cheesecake",
        Price = 7.99M,
        Description = "Classic New York cheesecake with a graham cracker crust.",
        SpecialTag = "Sweet Treat",
        CategoryId = 3,
        ImageUrl = "/images/product/cheesecake.jpg"
    }
);
        

             
            
        }
    }
}
