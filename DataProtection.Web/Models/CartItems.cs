using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataProtection.Web.Models
{
    public partial class CartItems
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int EditionId { get; set; }
        public int Quantity { get; set; }
    }
}
