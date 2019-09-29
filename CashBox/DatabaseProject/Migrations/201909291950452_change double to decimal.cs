namespace DatabaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedoubletodecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DailyCloses", "InitialAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.DailyCloses", "FinalAmount", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Transactions", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "Amount", c => c.Double(nullable: false));
            AlterColumn("dbo.DailyCloses", "FinalAmount", c => c.Double());
            AlterColumn("dbo.DailyCloses", "InitialAmount", c => c.Double(nullable: false));
        }
    }
}
