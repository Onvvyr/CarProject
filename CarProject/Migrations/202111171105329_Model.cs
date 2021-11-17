namespace CarProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cars", name: "Brand", newName: "Marka");
            AlterColumn("dbo.Cars", "Marka", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Marka", c => c.String());
            RenameColumn(table: "dbo.Cars", name: "Marka", newName: "Brand");
        }
    }
}
