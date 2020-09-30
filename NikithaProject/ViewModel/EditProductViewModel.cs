using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NikithaProject.ViewModel
{
    public class EditProductViewModel : ProductViewModel
    {
        public int Id { get; set; }
        public string ExistingImageName { get; set; }
    }
}
