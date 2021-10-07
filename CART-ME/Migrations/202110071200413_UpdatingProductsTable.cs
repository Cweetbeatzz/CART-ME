namespace CART_ME.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingProductsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomersModels", "Firstname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.CustomersModels", "Lastname", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomersModels", "Lastname", c => c.String(nullable: false));
            AlterColumn("dbo.CustomersModels", "Firstname", c => c.String(nullable: false));
        }
    }
}
