using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataProtection.Web.Models
{
    public partial class Categories
    {
        public Categories()
        {
            ProductCategories = new HashSet<ProductCategories>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }

        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
    }
}
