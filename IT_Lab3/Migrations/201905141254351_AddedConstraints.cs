﻿namespace IT_Lab3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedConstraints : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.FriendModels");
            AlterColumn("dbo.FriendModels", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.FriendModels", "Ime", c => c.String(nullable: false));
            AlterColumn("dbo.FriendModels", "MestoNaZiveenje", c => c.String(nullable: false));
            AddPrimaryKey("dbo.FriendModels", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.FriendModels");
            AlterColumn("dbo.FriendModels", "MestoNaZiveenje", c => c.String());
            AlterColumn("dbo.FriendModels", "Ime", c => c.String());
            AlterColumn("dbo.FriendModels", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.FriendModels", "ID");
        }
    }
}
