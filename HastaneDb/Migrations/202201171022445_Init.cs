namespace HastaneDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AileHekimleri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Tckn = c.String(),
                        DiplomaNo = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hastalar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Tckn = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        Adres = c.String(),
                        AileHekimleriId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AileHekimleri", t => t.AileHekimleriId, cascadeDelete: true)
                .Index(t => t.AileHekimleriId);
            
            CreateTable(
                "dbo.Muayeneler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MuayeneTarihi = c.DateTime(nullable: false),
                        HastalarId = c.Int(),
                        AileHekimleriId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AileHekimleri", t => t.AileHekimleriId, cascadeDelete: true)
                .ForeignKey("dbo.Hastalar", t => t.HastalarId)
                .Index(t => t.HastalarId)
                .Index(t => t.AileHekimleriId);
            
            CreateTable(
                "dbo.MuayeneHastaliklar",
                c => new
                    {
                        MuayenelerId = c.Int(nullable: false),
                        HastaliklarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MuayenelerId, t.HastaliklarId })
                .ForeignKey("dbo.Hastaliklar", t => t.HastaliklarId, cascadeDelete: true)
                .ForeignKey("dbo.Muayeneler", t => t.MuayenelerId, cascadeDelete: true)
                .Index(t => t.MuayenelerId)
                .Index(t => t.HastaliklarId);
            
            CreateTable(
                "dbo.Hastaliklar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HastalikAdi = c.String(),
                        ICD10 = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        UpdatedDate = c.DateTime(),
                        UpdatedById = c.Int(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MuayeneHastaliklar", "MuayenelerId", "dbo.Muayeneler");
            DropForeignKey("dbo.MuayeneHastaliklar", "HastaliklarId", "dbo.Hastaliklar");
            DropForeignKey("dbo.Muayeneler", "HastalarId", "dbo.Hastalar");
            DropForeignKey("dbo.Muayeneler", "AileHekimleriId", "dbo.AileHekimleri");
            DropForeignKey("dbo.Hastalar", "AileHekimleriId", "dbo.AileHekimleri");
            DropIndex("dbo.MuayeneHastaliklar", new[] { "HastaliklarId" });
            DropIndex("dbo.MuayeneHastaliklar", new[] { "MuayenelerId" });
            DropIndex("dbo.Muayeneler", new[] { "AileHekimleriId" });
            DropIndex("dbo.Muayeneler", new[] { "HastalarId" });
            DropIndex("dbo.Hastalar", new[] { "AileHekimleriId" });
            DropTable("dbo.Hastaliklar");
            DropTable("dbo.MuayeneHastaliklar");
            DropTable("dbo.Muayeneler");
            DropTable("dbo.Hastalar");
            DropTable("dbo.AileHekimleri");
        }
    }
}
