namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigratingMajor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Major", c => c.String());
            AddColumn("dbo.Student", "GPA", c => c.Int(nullable: false));
            AddColumn("dbo.Student", "EmailAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "EmailAddress");
            DropColumn("dbo.Student", "GPA");
            DropColumn("dbo.Student", "Major");
        }
    }
}
