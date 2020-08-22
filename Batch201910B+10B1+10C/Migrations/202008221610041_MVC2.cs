namespace Batch201910B_10B1_10C.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MVC2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactForms",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Contact = c.String(nullable: false),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactForms");
        }
    }
}
