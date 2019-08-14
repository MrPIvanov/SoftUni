using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var usersTextJson = File.ReadAllText(@"..\..\..\Datasets\users.json");
            var productsTextJson = File.ReadAllText(@"..\..\..\Datasets\products.json");
            var categoriesTextJson = File.ReadAllText(@"..\..\..\Datasets\categories.json");
            var categoriesProductsTextJson = File.ReadAllText(@"..\..\..\Datasets\categories-products.json");



            //Problem 01_Import Users
            ImportUsers(context, usersTextJson);

            //Problem 02_Import Products
            ImportProducts(context, productsTextJson);

            //Problem 03_Import Categories
            ImportCategories(context, categoriesTextJson);

            //Problem 04_Import Categories and Products
            ImportCategoryProducts(context, categoriesProductsTextJson);

            //Problem 05_Export Products In Range
            GetProductsInRange(context);

            //Problem 06_Export Successfully Sold Products
            GetSoldProducts(context);

            //Problem 07_Export Categories By Products Count
            GetCategoriesByProductsCount(context);

            //Problem 08_Export Users and Products
            GetUsersWithProducts(context);
        }

        //Problem 01_Import Users
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var validUsers = JsonConvert.DeserializeObject<List<User>>(inputJson)
                                        .Where(u => u.LastName != null && 
                                                    u.LastName.Length >= 3)
                                        .ToList();

            context.Users.AddRange(validUsers);
            context.SaveChanges();

            return $"Successfully imported {validUsers.Count}";
        }

        //Problem 02_Import Products
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var validProducts = JsonConvert.DeserializeObject<List<Product>>(inputJson)
                                            .Where(p => p.Name != null &&
                                                    p.Name.Length >= 3)
                                                    .ToList();

            context.Products.AddRange(validProducts);
            context.SaveChanges();

            return $"Successfully imported {validProducts.Count}";
        }

        //Problem 03_Import Categories
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var validCategories = JsonConvert.DeserializeObject<List<Category>>(inputJson)
                                            .Where(c => c.Name != null &&
                                                    c.Name.Length >= 3 &&
                                                    c.Name.Length <= 15)
                                            .ToList();

            context.Categories.AddRange(validCategories);
            context.SaveChanges();

            return $"Successfully imported {validCategories.Count}";
        }

        //Problem 04_Import Categories and Products
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var validCategoriesProducts = JsonConvert.DeserializeObject<List<CategoryProduct>>(inputJson)
                                                        .Where(cp => cp.CategoryId > 0 &&
                                                                    cp.ProductId > 0)
                                                        .ToList();

            context.CategoryProducts.AddRange(validCategoriesProducts);
            context.SaveChanges();

            return $"Successfully imported {validCategoriesProducts.Count}";
        }

        //Problem 05_Export Products In Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var productsToExport = context
                                    .Products
                                    .Where(p => p.Price >= 500 && p.Price <= 1000)
                                    .OrderBy(p => p.Price)
                                    .Select(p => new
                                    {
                                        name = p.Name,
                                        price = p.Price,
                                        seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                                    })
                                    .ToList();

            var productsToExportJson = JsonConvert.SerializeObject(productsToExport);

            return productsToExportJson;
        }

        //Problem 06_Export Successfully Sold Products
        public static string GetSoldProducts(ProductShopContext context)
        {
            var usersWithSoldProducts = context
                                                .Users
                                                .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                                                .OrderBy(u => u.LastName)
                                                .ThenBy(u => u.FirstName)
                                                .Select(u => new
                                                {
                                                    firstName = u.FirstName,
                                                    lastName = u.LastName,
                                                    soldProducts = u.ProductsSold
                                                                    .Select(p => new
                                                                    {
                                                                        name = p.Name,
                                                                        price = p.Price,
                                                                        buyerFirstName = p.Buyer.FirstName,
                                                                        buyerLastName = p.Buyer.LastName
                                                                    })
                                                                    .ToArray()
                                                }).ToList();

            var jsonToExport = JsonConvert.SerializeObject(usersWithSoldProducts);

            return jsonToExport;

        }

        //Problem 07_Export Categories By Products Count
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var objToExport = context
                              .Categories
                              .OrderByDescending(c => c.CategoryProducts.Count)
                              .Select(c => new
                              {
                                  category = c.Name,
                                  productsCount = c.CategoryProducts.Count,
                                  averagePrice = $"{c.CategoryProducts.Average(p => p.Product.Price):f2}",
                                  totalRevenue = $"{c.CategoryProducts.Sum(p => p.Product.Price):f2}"
                              })
                              .ToList();

            var jsonToExport = JsonConvert.SerializeObject(objToExport);

            return jsonToExport;
        }

        //Problem 08_Export Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var usersToExport = context
                              .Users
                              .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                              .OrderByDescending(u => u.ProductsSold.Count(p => p.Buyer.LastName != null))
                              .Select(u => new
                              {
                                  firstName = u.FirstName,
                                  lastName = u.LastName,
                                  age = u.Age,
                                  soldProducts = new
                                  {
                                      count = u.ProductsSold.Count(p => p.Buyer.LastName != null),
                                      products = u.ProductsSold 
                                                    .Where(p => p.Buyer.LastName != null)
                                                    .Select(p => new
                                                    {
                                                        name = p.Name,
                                                        price = p.Price
                                                    })
                                                    .ToArray()
                                  }
                              })
                              .ToList();

            var objToExport = new
            {
                usersCount = usersToExport.Count,
                users = usersToExport
            };

            var jsonToExport = JsonConvert.SerializeObject(objToExport, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return jsonToExport;
        }
    }
}