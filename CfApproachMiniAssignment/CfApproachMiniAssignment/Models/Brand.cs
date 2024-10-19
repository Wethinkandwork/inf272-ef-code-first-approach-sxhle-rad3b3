using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CfApproachMiniAssignment.Models
{
    public class Brand
    {
        [Key]
        public int Brand_Id { get; set; }
        [StringLength(50)]
        public string Brand_Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}