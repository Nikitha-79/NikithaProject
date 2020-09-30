using NikithaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NikithaProject.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void AddNewProduct(Product product);
    }
}
