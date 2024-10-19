using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.UI.WebControls;

namespace CfApproachMiniAssignment.Models
{
    public class Stock
    {
        [Key]
        public int Stock_Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        //FK
        public int? Product_Id { get; set; }
        public virtual Product Product{ get; set; }
        //FK
        public int? Store_Id { get; set; }
        public virtual Store Store { get; set; }
    }   
}