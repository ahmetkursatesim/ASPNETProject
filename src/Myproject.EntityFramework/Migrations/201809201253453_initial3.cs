namespace Myproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AbpUserPhoto", "Created_at");
            DropColumn("dbo.AbpUserPhoto", "Modified_at");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AbpUserPhoto", "Modified_at", c => c.DateTime(nullable: false));
            AddColumn("dbo.AbpUserPhoto", "Created_at", c => c.DateTime(nullable: false));
        }
    }
}
