namespace MihHiu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            PHIEUDATPHONGs = new HashSet<PHIEUDATPHONG>();
        }

        [Key]
        [StringLength(250)]
        public string MAKHACHHANG { get; set; }

        [Required]
        [StringLength(250)]
        public string HOTEN { get; set; }

        [Required]
        [StringLength(250)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string CCCD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDATPHONG> PHIEUDATPHONGs { get; set; }
    }
}
