﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuraFama.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bd_seguidoresEntities : DbContext
    {
        public bd_seguidoresEntities()
            : base("name=bd_seguidoresEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<administrador> administrador { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<disenador> disenador { get; set; }
        public virtual DbSet<proveedor> proveedor { get; set; }
        public virtual DbSet<servicio> servicio { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<vendedor> vendedor { get; set; }
        public virtual DbSet<venta> venta { get; set; }
        public virtual DbSet<login> login { get; set; }
    }
}