using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HandBook.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName="nvarchar(250)")]
        [Required]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string FatherName { get; set; }
        [Column(TypeName = "varint(20)")]
        public int Phone { get; set; }
        [Column(TypeName = "varchar(6)")]
        public string Sex { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Country { get; set; }
    }
}
