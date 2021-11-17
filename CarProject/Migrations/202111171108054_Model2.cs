namespace CarProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cars", name: "Marka", newName: "Brand");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Cars", name: "Brand", newName: "Marka");
        }
    }
}
