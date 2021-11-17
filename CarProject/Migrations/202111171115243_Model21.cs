namespace CarProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Model21 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Country", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Country", c => c.String());
        }
    }
}
