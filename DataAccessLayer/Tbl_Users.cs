//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Users
    {
        public int ID { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserType { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string UserImagePath { get; set; }
    }
}
