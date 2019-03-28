﻿using DesafioDataBase.Config;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            :base("")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new PorteEmpresaMap());
        }
    }
}