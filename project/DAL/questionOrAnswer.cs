//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class questionOrAnswer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public questionOrAnswer()
        {
            this.joinedFile = new HashSet<joinedFile>();
            this.questionOrAnswer1 = new HashSet<questionOrAnswer>();
        }
    
        public int id { get; set; }
        public int subjectId { get; set; }
        public int userId { get; set; }
        public string txt { get; set; }
        public Nullable<bool> finish { get; set; }
        public System.DateTime listingDate { get; set; }
        public Nullable<int> parentId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<joinedFile> joinedFile { get; set; }
        public virtual subjects subjects { get; set; }
        public virtual users users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<questionOrAnswer> questionOrAnswer1 { get; set; }
        public virtual questionOrAnswer questionOrAnswer2 { get; set; }
    }
}
