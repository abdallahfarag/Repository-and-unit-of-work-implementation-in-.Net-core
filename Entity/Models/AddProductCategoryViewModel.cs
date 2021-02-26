using Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Models
{
    public class AddProductCategoryViewModel
    {
        [Required]
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
    }
}
