namespace DatabaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyCloses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        InitialAmount = c.Double(nullable: false),
                        FinalAmount = c.Double(),
                        CasherId = c.Long(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CasherId, cascadeDelete: true)
                .Index(t => t.CasherId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        IsCasher = c.Boolean(nullable: false),
                        IsEnabled = c.Boolean(nullable: false),
                        Email = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TransactionType = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        OriginAccount = c.String(),
                        DestinyAccount = c.String(),
                        CasherId = c.Long(nullable: false),
                        Identification = c.String(),
                        IdentificationType = c.Int(),
                        CreationTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CasherId, cascadeDelete: true)
                .Index(t => t.CasherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "CasherId", "dbo.Users");
            DropForeignKey("dbo.DailyCloses", "CasherId", "dbo.Users");
            DropIndex("dbo.Transactions", new[] { "CasherId" });
            DropIndex("dbo.DailyCloses", new[] { "CasherId" });
            DropTable("dbo.Transactions");
            DropTable("dbo.Users");
            DropTable("dbo.DailyCloses");
        }
    }
}
