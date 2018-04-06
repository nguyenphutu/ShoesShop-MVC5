namespace ShoesShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_image_shoe_atribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shoes", "Image", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shoes", "Image");
        }
    }
}
