namespace MihHiu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPD")]
    public partial class CTPD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string MAPHIEUDAT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string MAPHONG { get; set; }

        public DateTime? NGAYTRAPHONG { get; set; }

        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
