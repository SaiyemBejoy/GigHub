namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedNameOfVenue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "Venue", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Gigs", "Venu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "Venu", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Gigs", "Venue");
        }
    }
}
