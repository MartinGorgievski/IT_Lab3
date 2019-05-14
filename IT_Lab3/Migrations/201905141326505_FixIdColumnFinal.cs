namespace IT_Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixIdColumnFinal : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.FriendModels");
            AddColumn("dbo.FriendModels", "FriendID", c => c.Int(nullable: false));
            AlterColumn("dbo.FriendModels", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FriendModels", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.FriendModels");
            AlterColumn("dbo.FriendModels", "ID", c => c.Int(nullable: false));
            DropColumn("dbo.FriendModels", "FriendID");
            AddPrimaryKey("dbo.FriendModels", "ID");
        }
    }
}
