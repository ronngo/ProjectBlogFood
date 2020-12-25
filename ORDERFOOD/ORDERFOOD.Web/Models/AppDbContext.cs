using Microsoft.EntityFrameworkCore;

namespace ORDERFOOD.Web.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<OrderFood> OrderFoods { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Gạo" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Thịt" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Hoa Quả" });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 1,
                ShortContent = "Gạo Lứt Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                
                Address = "Hue",
                Image = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                Price = 14,
                CategoryId = 1
            });
            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 2,
                ShortContent = "Gạo Lứt Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",

                Address = "Hue",
                Image = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                Price = 14,
                CategoryId = 2
            });
            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 3,
                ShortContent = "Gạo Lứt Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",

                Address = "Hue",
                Image = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                Price = 14,
                CategoryId = 1
            });
            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 4,
                ShortContent = "Gạo Lứt Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",

                Address = "Hue",
                Image = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                Price = 14,
                CategoryId = 3
            });
            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = 5,
                ShortContent = "Gạo Lứt Huế",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",

                Address = "Hue",
                Image = "https://acecookvietnam.cdn.vccloud.vn/wp-content/uploads/2017/07/590-HH-TCC.png",
                Price = 14,
                CategoryId = 1
            });

            modelBuilder.Entity<ProductTag>().HasKey(protag => new { protag.FoodId, protag.TagId });

            //Seeder data tag
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 1,
                Name = "Rẻ"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 2,
                Name = "Ngon"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                Id = 3,
                Name = "Bổ Khỏe"
            });
        }

    }
}
