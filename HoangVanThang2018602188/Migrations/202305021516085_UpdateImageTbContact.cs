namespace HoangVanThang2018602188.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateImageTbContact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Contact", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Contact", "Image");
        }
    }
}
