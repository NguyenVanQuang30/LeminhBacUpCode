using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HDSE.Models
{
    public class Employee
    {
        [Key]
        [Required(ErrorMessage = "ID khong duoc duoc trong")]
        public string EmployeeId { get; set; }
        [Required(ErrorMessage ="Ten khong duoc duoc trong")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Phong ban khong duoc de trong")]
        public string Department { get; set; }
        [Required(ErrorMessage ="Khong duoc de trong tien")]
        public double Salary { get; set; }
    }
}