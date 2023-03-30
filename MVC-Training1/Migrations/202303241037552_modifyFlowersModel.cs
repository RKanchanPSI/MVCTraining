namespace MVC_Training1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyFlowersModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flowers", "IsSelected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Flowers", "IsSelected");
        }
    }
}
