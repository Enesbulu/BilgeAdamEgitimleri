using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders32_CodeFirst_Linq.Model.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]  //Name için zorunluluk
        public string Name { get; set; }
        [Required]  //LastName için zorunluluk 
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
