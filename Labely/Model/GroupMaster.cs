//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Labely.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupMaster
    {
        public GroupMaster()
        {
            this.GroupDetails = new HashSet<GroupDetail>();
        }
    
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> Deletedate { get; set; }
    
        public virtual ICollection<GroupDetail> GroupDetails { get; set; }
    }
}