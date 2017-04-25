namespace BagOfMarbles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MarblesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marbles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Color = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Marbles");
        }
    }
}
