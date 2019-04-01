using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDataBase.Config
{
    public class PorteEmpresaMap : EntityTypeConfiguration<PorteEmpresa>
    {
        public PorteEmpresaMap()
        {
            HasKey(p => p.IDPorteEmpresa)
                .Property(p => p.IDPorteEmpresa).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(p => p.NomePorteEmpresa)
                .HasMaxLength(50)
                .IsRequired();
            Property(p => p.DataExclusao).IsOptional();
             
            HasMany(p => p.Clientes)
                .WithRequired(q => q.PorteEmpresa)
                .HasForeignKey(p => p.IDPorteEmpresa);
                
       
        }
    }
}
