namespace scoreboardVB10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAlbums : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Artist = c.String(),
                        AlbumName = c.String(),
                        Genre = c.String(),
                        CreatedDate = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Albums");
        }
    }
}
