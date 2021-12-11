using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Exam2.data
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employee1 { set; get; }
        public DbSet<Department> Department1 { set; get; }
        public DbSet<Country> Country1 { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;initial catalog=Exam2; Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
