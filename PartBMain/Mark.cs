//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PartBMain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mark()
        {
            this.Assignments = new HashSet<Assignment>();
        }
    
        public int MarkID { get; set; }
        public Nullable<double> Oral_Mark { get; set; }
        public Nullable<double> Write_Mark { get; set; }
        public Nullable<double> Total_Mark { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> Assignments { get; set; }

        public override string ToString()
        {
            return $"\n ID: {MarkID} Total Mark : {Total_Mark} Oral Mark: {Oral_Mark} Write Mark: {Write_Mark} ";
        }
    }
}
