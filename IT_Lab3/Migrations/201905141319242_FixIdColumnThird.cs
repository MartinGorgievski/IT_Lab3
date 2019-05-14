namespace IT_Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixIdColumnThird : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.FriendModels");
            AlterColumn("dbo.FriendModels", "ID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.FriendModels", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.FriendModels");
            AlterColumn("dbo.FriendModels", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FriendModels", "ID");
        }
    }
}
