namespace HoangVanThang2018602188.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTbContact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Contact", "Address", c => c.String(maxLength: 150));
            AddColumn("dbo.tb_Contact", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Contact", "Phone");
            DropColumn("dbo.tb_Contact", "Address");
        }
    }
}
