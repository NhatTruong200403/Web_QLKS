namespace MihHiu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDATPHONG")]
    public partial class PHIEUDATPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDATPHONG()
        {
            CTHDs = new HashSet<CTHD>();
            CTPDs = new HashSet<CTPD>();
        }

        [Key]
        [StringLength(250)]
        public string MAPHIEUDAT { get; set; }

        [Required]
        [StringLength(250)]
        public string MAKHACHHANG { get; set; }

        public DateTime? NGAYDAT { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPD> CTPDs { get; set; }
    }
}
