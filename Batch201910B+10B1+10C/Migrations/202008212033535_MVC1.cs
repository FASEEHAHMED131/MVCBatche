namespace Batch201910B_10B1_10C.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MVC1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblEmployee", "CNIC", c => c.String(nullable: false, maxLength: 13));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblEmployee", "CNIC");
        }
    }
}
