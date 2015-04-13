namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ImageData", c => c.Binary());
            AddColumn("dbo.Movies", "ImageMimeType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ImageMimeType");
            DropColumn("dbo.Movies", "ImageData");
        }
    }
}
