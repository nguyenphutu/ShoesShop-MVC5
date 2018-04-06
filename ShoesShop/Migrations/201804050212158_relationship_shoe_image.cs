namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relationship_shoe_image : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ImagesShoes", "Shoes_ID", "dbo.Shoes");
            DropIndex("dbo.ImagesShoes", new[] { "Shoes_ID" });
            RenameColumn(table: "dbo.ImagesShoes", name: "Shoes_ID", newName: "ShoeId");
            AlterColumn("dbo.ImagesShoes", "ShoeId", c => c.Int(nullable: false));
            CreateIndex("dbo.ImagesShoes", "ShoeId");
            AddForeignKey("dbo.ImagesShoes", "ShoeId", "dbo.Shoes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImagesShoes", "ShoeId", "dbo.Shoes");
            DropIndex("dbo.ImagesShoes", new[] { "ShoeId" });
            AlterColumn("dbo.ImagesShoes", "ShoeId", c => c.Int());
            RenameColumn(table: "dbo.ImagesShoes", name: "ShoeId", newName: "Shoes_ID");
            CreateIndex("dbo.ImagesShoes", "Shoes_ID");
            AddForeignKey("dbo.ImagesShoes", "Shoes_ID", "dbo.Shoes", "ID");
        }
    }
}
