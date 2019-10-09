namespace DatabaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_transaction_internal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "IsInternal", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Transactions", "IdentificationType", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "IdentificationType", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "IsInternal");
        }
    }
}
