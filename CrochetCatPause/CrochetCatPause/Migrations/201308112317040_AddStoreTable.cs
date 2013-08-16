namespace CrochetCatPause.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStoreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StoreItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(nullable: false, maxLength: 25),
                        PicUrl = c.String(nullable: false, maxLength: 1024),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StoreItems");
        }
    }
}
