namespace scoreboardVB10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScoreboardVBModels", "CreatedDate", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScoreboardVBModels", "CreatedDate");
        }
    }
}
