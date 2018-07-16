namespace Domain.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customers_NewColumnAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Continent", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Continent");
        }
    }
}
