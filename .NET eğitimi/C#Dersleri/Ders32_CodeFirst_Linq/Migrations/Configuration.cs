namespace Ders32_CodeFirst_Linq.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ders32_CodeFirst_Linq.Model.EmployeeDbContext>
    {
        public Configuration()
        {   
            AutomaticMigrationsEnabled = true;  //otomatik olarak oluşturması için ve update ile db e aktarıyor.
            AutomaticMigrationDataLossAllowed= true;    //Sadece update yapabilmek için bu satırı true olarak ayarlıyoruz.
        }

        protected override void Seed(Ders32_CodeFirst_Linq.Model.EmployeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
