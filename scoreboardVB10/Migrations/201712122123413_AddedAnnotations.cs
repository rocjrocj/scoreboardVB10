namespace scoreboardVB10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ScoreboardVBModels", "Set1Winner", c => c.String());
            AlterColumn("dbo.ScoreboardVBModels", "Set2Winner", c => c.String());
            AlterColumn("dbo.ScoreboardVBModels", "Set3Winner", c => c.String());
            AlterColumn("dbo.ScoreboardVBModels", "MatchDateTime", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ScoreboardVBModels", "MatchDateTime", c => c.Int(nullable: false));
            AlterColumn("dbo.ScoreboardVBModels", "Set3Winner", c => c.Int(nullable: false));
            AlterColumn("dbo.ScoreboardVBModels", "Set2Winner", c => c.Int(nullable: false));
            AlterColumn("dbo.ScoreboardVBModels", "Set1Winner", c => c.Int(nullable: false));
        }
    }
}
