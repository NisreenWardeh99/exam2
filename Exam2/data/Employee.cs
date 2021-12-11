
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Exam2.data
{
    [Table("Employees")]
    public class Employee
    {
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
       [RegularExpression("[07]{7,8,9}[0-9]{7}")]
        [Required]
        public string Phone { set; get; }
        [Required]
        public string Email { set; get; }
        [ForeignKey("dp")]
        public int department_id { set; get; }

        [ForeignKey("co")]
        public int Country_id { set; get; }
       // [Range("")]
        public DateTime Birth_Date { set; get; }
        public Department dp { set; get; }
        public Country co { set; get; }







        public string Image { set; get; }
       
    }
}
