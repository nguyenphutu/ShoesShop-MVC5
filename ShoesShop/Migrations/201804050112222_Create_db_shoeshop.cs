namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_db_shoeshop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShoeName = c.String(),
                        Descriptions = c.String(),
                        Infomations = c.String(),
                        Size = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Sale = c.Int(nullable: false),
                        Types = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ImagesShoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImageURL = c.String(),
                        Shoes_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Shoes", t => t.Shoes_ID)
                .Index(t => t.Shoes_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImagesShoes", "Shoes_ID", "dbo.Shoes");
            DropIndex("dbo.ImagesShoes", new[] { "Shoes_ID" });
            DropTable("dbo.ImagesShoes");
            DropTable("dbo.Shoes");
        }
    }
}
