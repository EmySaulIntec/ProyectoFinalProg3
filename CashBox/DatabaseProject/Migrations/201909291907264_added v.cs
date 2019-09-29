namespace DatabaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedv : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Status", c => c.Int(nullable: false));
            AlterColumn("dbo.Transactions", "IdentificationType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "IdentificationType", c => c.Int());
            DropColumn("dbo.Transactions", "Status");
        }
    }
}
