﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Caja_AppEntities : DbContext
    {
        public Caja_AppEntities()
            : base("name=Caja_AppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCajas> tblCajas { get; set; }
        public virtual DbSet<tblCuadres> tblCuadres { get; set; }
        public virtual DbSet<tblDenominaciones> tblDenominaciones { get; set; }
        public virtual DbSet<tblEstados_Caja> tblEstados_Caja { get; set; }
        public virtual DbSet<tblInventario_Efectivo> tblInventario_Efectivo { get; set; }
        public virtual DbSet<tblSucursales> tblSucursales { get; set; }
        public virtual DbSet<tblTipo_Transaccion> tblTipo_Transaccion { get; set; }
        public virtual DbSet<tblTipoDenominaciones> tblTipoDenominaciones { get; set; }
        public virtual DbSet<tblTiposDeUsuario> tblTiposDeUsuario { get; set; }
        public virtual DbSet<tblTransaccion> tblTransaccion { get; set; }
        public virtual DbSet<tblUsuarios> tblUsuarios { get; set; }
    
        public virtual ObjectResult<tblCajas_GetAll_Result> tblCajas_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblCajas_GetAll_Result>("tblCajas_GetAll");
        }
    
        public virtual ObjectResult<tblUsuarios_GetById_Result> tblUsuarios_GetById(Nullable<int> codigo_Usuario)
        {
            var codigo_UsuarioParameter = codigo_Usuario.HasValue ?
                new ObjectParameter("Codigo_Usuario", codigo_Usuario) :
                new ObjectParameter("Codigo_Usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tblUsuarios_GetById_Result>("tblUsuarios_GetById", codigo_UsuarioParameter);
        }
    }
}
