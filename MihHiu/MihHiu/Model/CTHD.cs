namespace MihHiu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string MAHOADON { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string MAPHIEUDAT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string MAPHONG { get; set; }

        [StringLength(250)]
        public string TONGTIEN { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
