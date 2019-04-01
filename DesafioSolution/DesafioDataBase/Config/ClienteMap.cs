using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entities;

namespace DesafioDataBase.Config
{
    public class ClienteMap: EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            HasKey(p => p.IDCliente)
                .Property(p => p.IDCliente).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(p => p.NomeCliente)
                .HasMaxLength(100)
                .IsRequired();
            Property(p => p.DataExclusao).IsOptional();




        }
    }
}
