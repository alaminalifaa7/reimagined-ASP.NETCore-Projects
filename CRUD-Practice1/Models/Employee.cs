﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Practice1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName= "nvarchar(250)")]
        //[Required]
        [Required(ErrorMessage ="This field is required")]
        [DisplayName ("Full Name")]
        public string FullName { get; set; }


        [Column(TypeName = "varchar(10)")]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; }


        [Column(TypeName = "varchar(100)")]
        [DisplayName("Position")]
        public string Position { get; set; } 


        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }

    }
}
