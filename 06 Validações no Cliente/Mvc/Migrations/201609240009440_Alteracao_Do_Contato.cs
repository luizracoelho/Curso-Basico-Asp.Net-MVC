namespace Mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteracao_Do_Contato : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contatos", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Contatos", "Telefone", c => c.String(nullable: false));
            AlterColumn("dbo.Contatos", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contatos", "Email", c => c.String());
            AlterColumn("dbo.Contatos", "Telefone", c => c.String());
            AlterColumn("dbo.Contatos", "Nome", c => c.String());
        }
    }
}
