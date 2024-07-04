namespace MihHiu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIPHONG")]
    public partial class LOAIPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIPHONG()
        {
            PHONGs = new HashSet<PHONG>();
        }

        [Key]
        [StringLength(250)]
        public string MALOAI { get; set; }

        [Required]
        [StringLength(250)]
        public string TENLOAI { get; set; }

        [Required]
        [StringLength(250)]
        public string GIAPHONG { get; set; }

        [StringLength(250)]
        public string SUCCHUA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG> PHONGs { get; set; }
    }
}
