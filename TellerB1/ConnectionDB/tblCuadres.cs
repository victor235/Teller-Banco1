//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tblCuadres
    {
        public int Id { get; set; }
        public decimal Balance_Inicial { get; set; }
        public System.DateTime Fecha_Apertura { get; set; }
        public decimal Balance_Final { get; set; }
        public System.DateTime Fecha_Cierre { get; set; }
        public int Caja { get; set; }
        public int Cajero { get; set; }
    
        public virtual tblCajas tblCajas { get; set; }
        public virtual tblUsuarios tblUsuarios { get; set; }
    }
}
