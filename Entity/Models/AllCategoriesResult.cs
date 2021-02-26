using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class AllCategoriesResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string ParentProductCategoryName { get; set; }
    }
}
