﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorsodItalia.BL
{
   public class Contexto: DbContext
    {
        internal object Clientes;

        //public Contexto(): base()
        public Contexto() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
        Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\MorsodItaliaDB.mdf")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ClientesBL>clientes { get; set; }
        public DbSet<Orden>Ordenes { get; set; }
        public DbSet<OrdenDetalle>OrdenDetalle { get; set; }
    }
}