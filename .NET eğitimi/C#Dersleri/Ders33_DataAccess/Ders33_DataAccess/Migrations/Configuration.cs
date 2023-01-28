namespace Ders33_DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ders33_DataAccess.Model.DataAccessDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;  //Her seferinde tekrar migrations etmemek için true yapıyoruz.
            AutomaticMigrationDataLossAllowed= true;    //Yapılan değişikliği direk olarak aktarmak için yapılıyor. Öncelikler migrations'u enable true olarak ayarlanmalı.
        }

        protected override void Seed(Ders33_DataAccess.Model.DataAccessDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
#region DB Comutları
/*  Enable-Migrations       --veritabanına ilk bağlantı kurulması
 *  Update-Database         --DB'i güncelleme.
 */
#endregion