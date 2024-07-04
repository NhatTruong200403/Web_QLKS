namespace MihHiu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            CTHDs = new HashSet<CTHD>();
            CTPDs = new HashSet<CTPD>();
        }

        [Key]
        [StringLength(250)]
        public string MAPHONG { get; set; }

        [Required]
        [StringLength(250)]
        public string MALOAIPHONG { get; set; }

        [Required]
        [StringLength(250)]
        public string SOPHONG { get; set; }

        [StringLength(250)]
        public string SOTANG { get; set; }

        public virtual LOAIPHONG LOAIPHONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPD> CTPDs { get; set; }
    }
}
