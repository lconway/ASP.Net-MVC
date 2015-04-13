namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String());
            DropColumn("dbo.Movies", "Rating");
        }
    }
}
