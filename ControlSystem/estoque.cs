//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class estoque
    {
        public int id { get; set; }
        public int quantidade { get; set; }
        public int estoqueMaximo { get; set; }
        public int estoqueMinimo { get; set; }
        public int lote_id { get; set; }
        public int status { get; set; }
    
        public virtual lote lote { get; set; }
    }
}
