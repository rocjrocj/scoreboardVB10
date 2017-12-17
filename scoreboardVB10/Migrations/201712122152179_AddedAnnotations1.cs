namespace scoreboardVB10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnnotations1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScoreboardVBModels", "MatchDateTime", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScoreboardVBModels", "MatchDateTime");
        }
    }
}
