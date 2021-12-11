using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Exam2.data
{
    [Table("Departments")]
    public class Department
    {
        public int ID { set; get; }
        public string Department_Name { set; get; }
        public int Minimum_Salary { set; get; }
        public int Maximum_Salary { set; get; }
        public List<Employee> em { set; get; }
    }
}
