namespace DatabaseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_mcoin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MCoins",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MCoins");
        }
    }
}
