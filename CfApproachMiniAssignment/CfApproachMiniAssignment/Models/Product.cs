using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CfApproachMiniAssignment.Models
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        [StringLength(100)]
        public string Product_Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Model_Year { get; set; }
        [Required]
        public decimal List_Price { get; set; }

        public ICollection<Stock> Stocks { get; set;}

        //FKs
        public int? Brand_Id { get; set; }
        public virtual Brand Brand { get; set; }
        public int? Category_Id { get; set; }
        public virtual Categories Categories { get; set; }


    }
}