//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpDesk
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lifecycle
    {
        public Lifecycle()
        {
            this.Requests = new HashSet<Request>();
        }
    
        public int Id { get; set; }
        public System.DateTime Opened { get; set; }
        public Nullable<System.DateTime> Distributed { get; set; }
        public Nullable<System.DateTime> Proccesing { get; set; }
        public Nullable<System.DateTime> Checking { get; set; }
        public Nullable<System.DateTime> Closed { get; set; }
    
        public virtual ICollection<Request> Requests { get; set; }
    }
}
