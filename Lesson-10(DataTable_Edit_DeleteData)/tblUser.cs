//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lesson_10_DataTable_Edit_DeleteData_
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUser
    {
        public int uId { get; set; }
        public string uName { get; set; }
        public string uEmail { get; set; }
        public string uPassword { get; set; }
        public Nullable<int> rId { get; set; }
    
        public virtual tblRole tblRole { get; set; }
    }
}
