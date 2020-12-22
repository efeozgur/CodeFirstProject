namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kisiler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        personelSicilNo = c.String(nullable: false, maxLength: 7),
                        personelAdSoyad = c.String(nullable: false, maxLength: 20),
                        cepTelefonu = c.String(),
                        dahiliNo = c.String(),
                        dahiliNo2 = c.String(),
                        Unvan_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Unvanlar", t => t.Unvan_ID)
                .Index(t => t.Unvan_ID);
            
            CreateTable(
                "dbo.Unvanlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Unvan = c.String(nullable: false, maxLength: 75),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kisiler", "Unvan_ID", "dbo.Unvanlar");
            DropIndex("dbo.Kisiler", new[] { "Unvan_ID" });
            DropTable("dbo.Unvanlar");
            DropTable("dbo.Kisiler");
        }
    }
}
