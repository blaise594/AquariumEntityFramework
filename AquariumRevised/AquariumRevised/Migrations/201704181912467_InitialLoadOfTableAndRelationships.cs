namespace AquariumRevised.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialLoadOfTableAndRelationships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AALO",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AquariumId = c.Int(nullable: false),
                        AquaticLifeId = c.Int(nullable: false),
                        OceanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aquarium", t => t.AquariumId, cascadeDelete: true)
                .ForeignKey("dbo.AquaticLife", t => t.AquaticLifeId, cascadeDelete: true)
                .ForeignKey("dbo.Ocean", t => t.OceanId, cascadeDelete: true)
                .Index(t => t.AquariumId)
                .Index(t => t.AquaticLifeId)
                .Index(t => t.OceanId);
            
            CreateTable(
                "dbo.Aquarium",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AquaticLife",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        ISinQuarantine = c.Boolean(nullable: false),
                        DateAddedToTank = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ocean",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AverageTemperature = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AALO", "OceanId", "dbo.Ocean");
            DropForeignKey("dbo.AALO", "AquaticLifeId", "dbo.AquaticLife");
            DropForeignKey("dbo.AALO", "AquariumId", "dbo.Aquarium");
            DropIndex("dbo.AALO", new[] { "OceanId" });
            DropIndex("dbo.AALO", new[] { "AquaticLifeId" });
            DropIndex("dbo.AALO", new[] { "AquariumId" });
            DropTable("dbo.Ocean");
            DropTable("dbo.AquaticLife");
            DropTable("dbo.Aquarium");
            DropTable("dbo.AALO");
        }
    }
}
