//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOAD_Proj.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Event
    {
        [DisplayName("Event ID")]
        public int e_id { get; set; }
        [DisplayName("Event Name")]
        public string e_name { get; set; }
        [DisplayName("Event Description")]
        public string e_desc { get; set; }
        public Nullable<int> S_semester { get; set; }
    
        public virtual Semester Semester { get; set; }
    }
}
