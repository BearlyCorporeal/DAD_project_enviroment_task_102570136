//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFdemoAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASSIGNMENT
    {
        public string LOCCODE { get; set; }
        public string STAFFID { get; set; }
        public System.DateTime DATEASSIGNED { get; set; }
    
        public virtual Office Office { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
    }
}
