namespace DesafioDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IDCliente = c.Int(nullable: false, identity: true),
                        NomeCliente = c.String(nullable: false, maxLength: 100),
                        IDPorteEmpresa = c.Int(nullable: false),
                        DataExclusao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IDCliente)
                .ForeignKey("dbo.PorteEmpresa", t => t.IDPorteEmpresa, cascadeDelete: true)
                .Index(t => t.IDPorteEmpresa);
            
            CreateTable(
                "dbo.PorteEmpresa",
                c => new
                    {
                        IDPorteEmpresa = c.Int(nullable: false, identity: true),
                        NomePorteEmpresa = c.String(nullable: false, maxLength: 50),
                        DataExclusao = c.DateTime(nullable: false),
                        DataModificacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IDPorteEmpresa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "IDPorteEmpresa", "dbo.PorteEmpresa");
            DropIndex("dbo.Cliente", new[] { "IDPorteEmpresa" });
            DropTable("dbo.PorteEmpresa");
            DropTable("dbo.Cliente");
        }
    }
}
