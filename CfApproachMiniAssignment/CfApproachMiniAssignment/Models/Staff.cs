using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CfApproachMiniAssignment.Models
{
    public class Staff
    {
        [Key]
        public int Staff_Id { get; set; }
        [StringLength(50)]
        public string First_Name { get; set; }
        [StringLength(50)]
        public string last_Name { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(10)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Active { get; set; }

        //FK
        public int? Store_Id { get; set; }
        public virtual Store Store { get; set; }

    }
}