namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Birimler : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Birimler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BirimAdi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Birimler");
        }
    }
}
