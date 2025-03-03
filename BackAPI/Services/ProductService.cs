﻿using BackAPI.Entity;
using BackAPI.Models;
using BackAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace BackAPI.Services
{
    public class ProductService : IProductService
    {
        public async Task<bool> AddProduct(ProductModel productModel)
        {
            using var context = new Context();

            var product = new Product
            {

                ProductName = GetRandomStr(),
                ProductId = Guid.NewGuid(),
            };
            context.Products.Add(product);

            return await context.SaveChangesAsync() > 0;
        }
        private static string GetRandomStr()
        {
            int x = GetRandomInt(4, 10);

            string str = "";
            var r = new Random();
            while (str.Length < x)
            {
                char c = (char)r.Next(33, 125);
                if (char.IsLetterOrDigit(c))
                    str += c;
            }
            return str;
        }

        private static int GetRandomInt(int from, int to)
        {
            var dig = new Random();
            int x = dig.Next(from, to);
            return x;
        }

        private static DateTime GetRandomDate()
        {
            var gen = new Random();
            var start = new DateTime(1995, 1, 1);
            int range = (new DateTime(2006, 1, 1) - start).Days;
            return start.AddDays(gen.Next(range));
        }
        public async Task<List<Product>> GetAllProducts()
        {
            using var context = new Context();
            return await context.Products.ToListAsync();
        }
    }
}
