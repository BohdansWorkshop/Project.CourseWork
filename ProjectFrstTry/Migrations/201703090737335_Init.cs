namespace ProjectFrstTry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Visitors",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Destination = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        editedTime = c.DateTime(nullable: false),
                        Type_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VisitorTypes", t => t.Type_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.VisitorTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 200),
                        Parent_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VisitorTypes", t => t.Parent_Id)
                .Index(t => t.Parent_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visitors", "Type_Id", "dbo.VisitorTypes");
            DropForeignKey("dbo.VisitorTypes", "Parent_Id", "dbo.VisitorTypes");
            DropIndex("dbo.VisitorTypes", new[] { "Parent_Id" });
            DropIndex("dbo.Visitors", new[] { "Type_Id" });
            DropTable("dbo.VisitorTypes");
            DropTable("dbo.Visitors");
        }
    }
}
