//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterSweets.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class guest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public guest()
        {
            this.carts = new HashSet<cart>();
            this.orders = new HashSet<order>();
        }
    
        public int guest_id { get; set; }
        public string session_id { get; set; }
        public string guest_Name { get; set; }
        public string guest_email { get; set; }
        public string guest_address { get; set; }
        public string guest_street { get; set; }
        public string guest_city { get; set; }
        public int guest_buldingNO { get; set; }
        public string guest_phone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cart> carts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}