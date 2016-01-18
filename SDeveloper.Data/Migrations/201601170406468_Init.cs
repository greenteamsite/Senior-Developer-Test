namespace SDeveloper.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Created = c.DateTime(nullable: false),
                        Type = c.String(maxLength: 100),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Type);

            CreateStoredProcedure(
                "dbo.GetEntitiesByType",
                p => new
                {
                    Type = p.String(),
                },
                body:
                    @"SELECT * FROM [dbo].[Entities] AS ent WHERE ent.[Type] = @Type"
                );
        }
        
        public override void Down()
        {
            DropIndex("dbo.Entities", new[] { "Type" });
            DropTable("dbo.Entities");
        }
    }
}
