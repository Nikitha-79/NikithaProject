using NikithaProject.Data;
using NikithaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NikithaProject.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _dbContext = null;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddNewProduct(Product product)
        {
            if(product!=null)
            {
                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException(nameof(product));
            }
        }

        public int EditProduct(Product product)
        {
            var prodfromDb = _dbContext.Products.SingleOrDefault(p => p.Id == product.Id);
            if(prodfromDb != null)
            {
                prodfromDb.Name = product.Name;
                prodfromDb.Description = product.Description;
                prodfromDb.Price = product.Price;
                prodfromDb.ImageName = product.ImageName;
                return _dbContext.SaveChanges();
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public Product GetProductById(int id)
        {
            return _dbContext.Products.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }
    }
}
