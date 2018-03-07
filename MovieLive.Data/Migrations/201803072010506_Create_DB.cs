namespace MovieLive.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AuditableEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.Int(),
                        CreatedDate = c.DateTime(),
                        UpdatedBy = c.Int(),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AuditableEntities");
        }
    }
}
