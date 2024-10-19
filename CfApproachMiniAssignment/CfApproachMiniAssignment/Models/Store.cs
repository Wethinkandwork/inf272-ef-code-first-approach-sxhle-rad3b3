using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CfApproachMiniAssignment.Models
{
    public class Store
    {
        [Key]
        public int Store_Id { get; set; }
        [StringLength(100)]
        public string Store_Name { get; set; }
        [StringLength(10)]
        public string Phone { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Street { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string State { get; set; }
        [StringLength(100)]
        public string Zip_Code { get; set; }

        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Staff> Staffs { get; set; }
    }
}