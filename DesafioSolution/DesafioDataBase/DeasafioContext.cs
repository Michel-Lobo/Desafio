using DesafioDataBase.Config;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDataBase
{
    public class DesafioContext: DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<PorteEmpresa> PorteEmpresa { get; set; }
        public DesafioContext()
            :base("DBDesafio")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new PorteEmpresaMap());
        }
        public override int SaveChanges()
        {
            var changeSet = ChangeTracker.Entries<BaseEntity>();
            if (changeSet != null)
            {
                foreach (var entry in changeSet.Where(c => c.State == EntityState.Added || c.State == EntityState.Modified))
                {
                    entry.Entity.DataModificacao = DateTime.Now;
                    
                }
            }
            
            return base.SaveChanges();
        }
    }
}
