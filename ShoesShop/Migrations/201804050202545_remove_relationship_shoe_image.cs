namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_relationship_shoe_image : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ImagesShoes", "ShoeId", "dbo.Shoes");
            DropIndex("dbo.ImagesShoes", new[] { "ShoeId" });
            RenameColumn(table: "dbo.ImagesShoes", name: "ShoeId", newName: "Shoes_ID");
            AlterColumn("dbo.ImagesShoes", "Shoes_ID", c => c.Int());
            CreateIndex("dbo.ImagesShoes", "Shoes_ID");
            AddForeignKey("dbo.ImagesShoes", "Shoes_ID", "dbo.Shoes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImagesShoes", "Shoes_ID", "dbo.Shoes");
            DropIndex("dbo.ImagesShoes", new[] { "Shoes_ID" });
            AlterColumn("dbo.ImagesShoes", "Shoes_ID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.ImagesShoes", name: "Shoes_ID", newName: "ShoeId");
            CreateIndex("dbo.ImagesShoes", "ShoeId");
            AddForeignKey("dbo.ImagesShoes", "ShoeId", "dbo.Shoes", "ID", cascadeDelete: true);
        }
    }
}
