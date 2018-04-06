namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_atributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shoes", "ShoeTitle", c => c.String(nullable: false));
            AlterColumn("dbo.Shoes", "ShoeName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Shoes", "Descriptions", c => c.String(nullable: false));
            AlterColumn("dbo.Shoes", "Infomations", c => c.String(nullable: false));
            AlterColumn("dbo.ImagesShoes", "ImageURL", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ImagesShoes", "ImageURL", c => c.String());
            AlterColumn("dbo.Shoes", "Infomations", c => c.String());
            AlterColumn("dbo.Shoes", "Descriptions", c => c.String());
            AlterColumn("dbo.Shoes", "ShoeName", c => c.String());
            DropColumn("dbo.Shoes", "ShoeTitle");
        }
    }
}
