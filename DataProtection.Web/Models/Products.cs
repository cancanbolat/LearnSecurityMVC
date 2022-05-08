using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataProtection.Web.Models
{
    public partial class Products
    {
        public Products()
        {
            ProductCategories = new HashSet<ProductCategories>();
            ProductVariants = new HashSet<ProductVariants>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        //şifrelenmiş veri (neyi şifreleyeceksek)
        [NotMapped]
        public string EncrypedId { get; set; }


        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
        public virtual ICollection<ProductVariants> ProductVariants { get; set; }
    }
}
