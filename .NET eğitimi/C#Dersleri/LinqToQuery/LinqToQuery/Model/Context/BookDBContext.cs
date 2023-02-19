using LinqToQuery.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToQuery.Model.Context
{
    internal class BookDBContext:DbContext
    {
        public BookDBContext() : base("DbConnection") { }     //("name=DbConnection")

        public DbSet<Genre> Genres{ get; set; }
        public DbSet<Book> Books { get; set; }


    }
}
