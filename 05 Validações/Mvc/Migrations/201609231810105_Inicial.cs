namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        ContatoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Idade = c.Int(nullable: false),
                        Telefone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ContatoId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Contatos");
        }
    }
}
