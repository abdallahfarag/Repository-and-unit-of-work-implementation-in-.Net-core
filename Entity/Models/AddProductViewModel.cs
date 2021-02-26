using Entity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class AddProductViewModel
    {
        public Product Product { get; set; }
        public IFormFile[] Photos { get; set; }
    }
}
