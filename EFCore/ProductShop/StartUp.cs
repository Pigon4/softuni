using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DTOs.Import;
using ProductShop.Models;


namespace ProductShop
{
    public class StartUp
    {
        public static void Main()
        {
            ProductShopContext productShopContext = new ProductShopContext();
            string result = GetSoldProducts(productShopContext);
            Console.WriteLine(result);
        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var users = JsonConvert.DeserializeObject<ImportUserDto[]>(inputJson);

            foreach (var item in users)
            {
                User user = new User();
                user.FirstName = item.FirstName ?? "";
                user.LastName = item.LastName ?? "";
                user.Age = item.Age;
                context.Users.AddRange(user);
            }
            context.SaveChanges();
            return $"Successfully imported {users.Count()}"; 
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var categories = JsonConvert.DeserializeObject<ImportCategoryDto[]>(inputJson);
            int c = 0;
            foreach (var item in categories)
            {
                Category category = new Category();
                if (item.name != null)
                {
                    c++;
                    category.Name = item.name;
                    context.Categories.AddRange(category);
                }
            }
            context.SaveChanges();
            return $"Successfully imported {c}";
        }
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            }));

            var productsDtos = JsonConvert.DeserializeObject<ImportProductsDto[]>(inputJson);
            Product[] products = mapper.Map<Product[]>(productsDtos);
            context.Products.AddRange(products);
            context.SaveChanges();
            return $"Successfully imported {productsDtos.Count()}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            }));

            var cpDtos =JsonConvert.DeserializeObject<ImportCategorisProductsDto[]>(inputJson);
            CategoryProduct[] categoryProducts = mapper.Map<CategoryProduct[]>(cpDtos);

            context.CategoriesProducts.AddRange(categoryProducts);
            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Count()}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
                var products = context.Products
                    .AsNoTracking()
                    .Where(x => x.Price >= 500 && x.Price <= 1000)
                    .Select(x => new
                    {
                        name = x.Name,
                        price = x.Price,
                        seller = x.Seller.FirstName + " " + x.Seller.LastName

                    }).OrderBy(x => x.price)
                    .ToArray();

            return JsonConvert.SerializeObject(products, Formatting.Indented);
           
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var products = context.Users
                .AsNoTracking()
                .Where(x =>x.ProductsSold.Any(x => x.Buyer!=null))
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    soldProducts = x.ProductsSold
                    .Where(b => b.Buyer != null)
                        .Select(p => new
                        {
                            name = p.Name,
                            price = p.Price,
                            buyerFirstName = p.Buyer.FirstName,
                            buyerLastName = p.Buyer.LastName

                        })
                }).OrderBy(l => l.lastName)
                .ThenBy(f => f.firstName)
                .ToArray();

            return JsonConvert.SerializeObject(products, Formatting.Indented);
        }

    }

}