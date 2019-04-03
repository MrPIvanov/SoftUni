using ProductShop.Data;
using ProductShop.Dtos.Export;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var categoriesXml = File.ReadAllText("../../../Datasets/categories.xml");
            var categoriesProductsXml = File.ReadAllText("../../../Datasets/categories-products.xml");
            var productsXml = File.ReadAllText("../../../Datasets/products.xml");
            var usersXml = File.ReadAllText("../../../Datasets/users.xml");



            //Problem_01_Import Users
            ImportUsers(context, usersXml);

            //Problem_02_Import Products
            ImportProducts(context, productsXml);

            //Problem_03_Import Categories
            ImportCategories(context, categoriesXml);

            //Problem_04_Import Categories and Products
            ImportCategoryProducts(context, categoriesProductsXml);

            //Problem_05_Products In Range
            GetProductsInRange(context);

            //Problem_06_Sold Products
            GetSoldProducts(context);

            //Problem_07_Categories By Products Count
            GetCategoriesByProductsCount(context);

            //Problem_08_Users and Products
            GetUsersWithProducts(context);
        }

        //Problem_01_Import Users
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportUsersDto[]), new XmlRootAttribute("Users"));

            var usersDto = (ImportUsersDto[])serializer.Deserialize(new StringReader(inputXml));

            var validUsers = new List<User>();

            foreach (var user in usersDto)
            {
                var validUser = new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Age = user.Age
                };

                validUsers.Add(validUser);
            }

            context.Users.AddRange(validUsers);
            context.SaveChanges();

            return $"Successfully imported {validUsers.Count}";
        }

        //Problem_02_Import Products
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportProductsDto[]), new XmlRootAttribute("Products"));

            var productsDto = (ImportProductsDto[])serializer.Deserialize(new StringReader(inputXml));

            var validProducts = new List<Product>();

            foreach (var product in productsDto)
            {
                var validProduct = new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    SellerId = product.SellerId,
                    BuyerId = product.BuyerId
                };

                validProducts.Add(validProduct);
            }

            context.Products.AddRange(validProducts);
            context.SaveChanges();

            return $"Successfully imported {validProducts.Count}";
        }

        //Problem_03_Import Categories
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportCategoryDto[]), new XmlRootAttribute("Categories"));

            var categoriesDtos = (ImportCategoryDto[])serializer.Deserialize(new StringReader(inputXml));

            var validCategories = new List<Category>();

            foreach (var category in categoriesDtos)
            {
                if (category.Name == null)
                {
                    continue;
                }

                var validCategory = new Category
                {
                    Name = category.Name
                };

                validCategories.Add(validCategory);
            }

            context.Categories.AddRange(validCategories);
            context.SaveChanges();

            return $"Successfully imported {validCategories.Count}";
        }

        //Problem_04_Import Categories and Products
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportCategoriesProductsDto[]), new XmlRootAttribute("CategoryProducts"));

            var categoryProductDtos = (ImportCategoriesProductsDto[])serializer.Deserialize(new StringReader(inputXml));

            var validData = new List<CategoryProduct>();

            foreach (var categoryProduct in categoryProductDtos)
            {
                var product = context.Products.Find(categoryProduct.ProductId);
                var category = context.Categories.Find(categoryProduct.CategoryId);

                if (product == null || category == null)
                {
                    continue;
                }

                var validCategoryProduct = new CategoryProduct
                {
                    CategoryId = categoryProduct.CategoryId,
                    ProductId = categoryProduct.ProductId
                };

                validData.Add(validCategoryProduct);
            }

            context.CategoryProducts.AddRange(validData);
            context.SaveChanges();

            return $"Successfully imported {validData.Count}";
        }

        //Problem_05_Products In Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var validData = context
                                .Products
                                .Where(p => p.Price >= 500 && p.Price <= 1000)
                                .OrderBy(p => p.Price)
                                .Take(10)
                                .Select(p => new ExportProductsInRangeDto
                                {
                                    Name = p.Name,
                                    Price = p.Price,
                                    Buyer = p.Buyer.FirstName + " " + p.Buyer.LastName
                                })
                                .ToArray();

            var serializer = new XmlSerializer(typeof(ExportProductsInRangeDto[]), new XmlRootAttribute("Products"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new [] 
            {
                new XmlQualifiedName("","")
            });

            serializer.Serialize(new StringWriter(sb), validData, namespaces);

            return sb.ToString().TrimEnd();
        }

        //Problem_06_Sold Products
        public static string GetSoldProducts(ProductShopContext context)
        {
            var validData = context
                            .Users
                            .Where(u => u.ProductsSold.Any())
                            .OrderBy(u => u.LastName)
                            .ThenBy(u => u.FirstName)
                            .Take(5)
                            .Select(u => new ExportUserWithSoldItemDto
                            {
                                FirstName = u.FirstName,
                                LastName = u.LastName,
                                SoldProducts = u
                                                .ProductsSold
                                                .Select(p => new LocalProductNamePriceDto
                                                {
                                                    Name = p.Name,
                                                    Price = p.Price
                                                })
                                                .ToArray()
                            })
                            .ToArray();

            var serializer = new XmlSerializer(typeof(ExportUserWithSoldItemDto[]), new XmlRootAttribute("Users"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("","")
            });

            serializer.Serialize(new StringWriter(sb), validData, namespaces);

            return sb.ToString().TrimEnd();
        }

        //Problem_07_Categories By Products Count
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var validData = context
                                    .Categories
                                    .Select(c => new ExportCategoriesByAvgAndTotalPriceDto
                                    {
                                        Name = c.Name,
                                        Count = c.CategoryProducts.Count(),
                                        AveragePrice = c.CategoryProducts.Average(p => p.Product.Price),
                                        TotalRevenue = c.CategoryProducts.Sum(p => p.Product.Price)
                                    })
                                    .OrderByDescending(x => x.Count)
                                    .ThenBy(x => x.TotalRevenue)
                                    .ToArray();

            var serializer = new XmlSerializer(typeof(ExportCategoriesByAvgAndTotalPriceDto[]), new XmlRootAttribute("Categories"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("","")
            });

            serializer.Serialize(new StringWriter(sb), validData, namespaces);

            return sb.ToString().TrimEnd();
        }

        //Problem_08_Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var validData = new ExportUsersAndProducts
            {
                Count = context
                        .Users
                        .Where(i => i.ProductsSold.Any())
                        .Count(),

                Users = context
                        .Users
                        .Where(u => u.ProductsSold.Any())
                        .OrderByDescending(u => u.ProductsSold.Count())
                        .Take(10)
                        .Select(u => new LocalUserForUserAndProductsDto
                        {
                            Age = u.Age,
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            SoldProducts = new LocalSoldProductsDto
                            {
                                Count = u.ProductsSold.Count(),
                                Products = u.ProductsSold.Select(p => new LocalProductDto
                                {
                                    Name = p.Name,
                                    Price = p.Price
                                })
                                .OrderByDescending(p => p.Price)
                                .ToArray()
                            }
                        })
                        .ToArray()
            };

            var serializer = new XmlSerializer(typeof(ExportUsersAndProducts));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("","")
            });

            serializer.Serialize(new StringWriter(sb), validData, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}