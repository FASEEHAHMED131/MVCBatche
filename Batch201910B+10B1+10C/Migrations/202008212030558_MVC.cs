namespace Batch201910B_10B1_10C.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MVC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblEmployee", "BirthDay", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblEmployee", "BirthDay");
        }
    }
}
