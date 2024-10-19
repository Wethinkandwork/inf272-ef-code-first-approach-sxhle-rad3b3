using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CfApproachMiniAssignment.Models
{
    public class Categories
    {
        [Key]
        public int Category_Id { get; set; }
        [StringLength(100)]
        public string Category_Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}