using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey(nameof(ProductCategory))]
        public int? ParentCategoryId { get; set; }
        public virtual ProductCategory ParentProductCategory { get; set; }
        public virtual ICollection<ProductCategory> SubCategories { get; set; } = new HashSet<ProductCategory>();
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
