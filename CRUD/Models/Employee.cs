using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Employee Name")]
        public string Name { get; set; }
       
        [Range(16,64)]
        public int Age { get; set; }
        [StringLength(160)]
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public string Position { get; set; }


    }
}