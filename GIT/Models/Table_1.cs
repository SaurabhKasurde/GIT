//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GIT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_1
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> Contact { get; set; }
    
        public virtual Table_2 Table_2 { get; set; }
    }
}
