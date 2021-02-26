using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [ForeignKey(nameof(ProductCategory))]
        public int ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        [DisplayName("Product Image")]
        public virtual ICollection<ProductImages> ProductImages { get; set; } = new HashSet<ProductImages>();
    }
}
