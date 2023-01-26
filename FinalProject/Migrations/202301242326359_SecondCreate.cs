namespace FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "partyType", c => c.Int(nullable: false));
            DropColumn("dbo.Events", "type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "type", c => c.String());
            DropColumn("dbo.Events", "partyType");
        }
    }
}
