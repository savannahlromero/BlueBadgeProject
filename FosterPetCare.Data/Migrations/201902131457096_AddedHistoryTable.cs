namespace FosterPetCare.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHistoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.History",
                c => new
                    {
                        HistoryID = c.Int(nullable: false, identity: true),
                        AnimalID = c.Int(nullable: false),
                        CaretakerID = c.Int(nullable: false),
                        HistoryCareType = c.Int(nullable: false),
                        DateOfCareStart = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HistoryID)
                .ForeignKey("dbo.Animal", t => t.AnimalID, cascadeDelete: true)
                .ForeignKey("dbo.Caretaker", t => t.CaretakerID, cascadeDelete: true)
                .Index(t => t.AnimalID)
                .Index(t => t.CaretakerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.History", "CaretakerID", "dbo.Caretaker");
            DropForeignKey("dbo.History", "AnimalID", "dbo.Animal");
            DropIndex("dbo.History", new[] { "CaretakerID" });
            DropIndex("dbo.History", new[] { "AnimalID" });
            DropTable("dbo.History");
        }
    }
}
