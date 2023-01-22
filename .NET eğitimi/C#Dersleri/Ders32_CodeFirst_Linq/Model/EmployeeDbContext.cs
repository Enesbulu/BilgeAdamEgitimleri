using Ders32_CodeFirst_Linq.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders32_CodeFirst_Linq.Model
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(): base("myConnectionString")  //Ana sınıf icerisindeki constructer metodu çalışır.
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
