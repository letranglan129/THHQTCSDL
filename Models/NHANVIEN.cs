//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.HOADONBANHANGs = new HashSet<HOADONBANHANG>();
            this.HOADONNHAPHANGs = new HashSet<HOADONNHAPHANG>();
        }
    
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public string CHUCVU { get; set; }
        public Nullable<int> NGAYCONG { get; set; }
        public Nullable<decimal> LUONGCOBAN { get; set; }
        public Nullable<decimal> TONGLUONG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONBANHANG> HOADONBANHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONNHAPHANG> HOADONNHAPHANGs { get; set; }
    }
}
