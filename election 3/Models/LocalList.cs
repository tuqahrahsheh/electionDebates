//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace election_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LocalList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocalList()
        {
            this.LocalListCandidates = new HashSet<LocalListCandidates>();
        }
    
        public int ID { get; set; }
        public string ListName { get; set; }
        public Nullable<int> NumberOfVotes { get; set; }
        public string ElectionArea { get; set; }
        public string Governorate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocalListCandidates> LocalListCandidates { get; set; }
    }
}
