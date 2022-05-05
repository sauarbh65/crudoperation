using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crudoperation.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public virtual Category Category { get; set; }
    }
}