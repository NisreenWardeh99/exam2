using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Exam2.data
{
    [Table("Countries")]
    public class Country
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public List<Employee> em { set; get; }
    }
}
