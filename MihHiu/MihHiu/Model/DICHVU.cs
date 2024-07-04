namespace MihHiu.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DICHVU")]
    public partial class DICHVU
    {
        [Key]
        [StringLength(250)]
        public string MADICHVU { get; set; }

        [Required]
        [StringLength(250)]
        public string TENDICHVU { get; set; }

        [StringLength(250)]
        public string GIATIEN { get; set; }
    }
}
