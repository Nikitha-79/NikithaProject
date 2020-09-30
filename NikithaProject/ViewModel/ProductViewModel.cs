using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NikithaProject.ViewModel
{
    public class ProductViewModel
    {
        [Required]
        [Display(Name ="ProductName")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        [Display(Name = "Image File Name")]
        public IFormFile ImageName { get; set; }
    }
}
