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
    
    public partial class usuario
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> lastLogin { get; set; }
        public int perfil { get; set; }
        public int funcionario_id { get; set; }
    
        public virtual funcionario funcionario { get; set; }
    }
}
