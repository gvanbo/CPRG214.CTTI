//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPRG214.CTTI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Authentication
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int StudentId { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
