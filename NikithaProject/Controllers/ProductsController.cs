using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NikithaProject.Data;
using NikithaProject.Models;
using NikithaProject.Repositories;
using NikithaProject.ViewModel;

namespace NikithaProject.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository _productRepository = null;
        private IWebHostEnvironment _webHostEnvironment = null;

        public ProductsController(IProductRepository productRepository,IWebHostEnvironment webHostEnvironment)
        {
            _productRepository = productRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            string folderName = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
            string imgFilePath = Path.Combine(folderName, product.ImageName.FileName);//C:/DXC/.../MyProject/Images/Roll_Bun.jpg
            product.ImageName.CopyTo(new FileStream(imgFilePath, FileMode.Create));

            Product prd = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageName = product.ImageName.FileName
            };

            _productRepository.AddNewProduct(prd);
            return RedirectToAction("Index", "Home");
        }
    }
}
