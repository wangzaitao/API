namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_advertise_5x")]
    public partial class sline_advertise_5x
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long webid { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string flag { get; set; }

        [StringLength(255)]
        public string custom_label { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string adsrc { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string adlink { get; set; }

        [Column(TypeName = "tinytext")]
        [StringLength(255)]
        public string adname { get; set; }

        [StringLength(255)]
        public string adorder { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string is_system { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string is_show { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string is_pc { get; set; }

        [Required]
        [StringLength(100)]
        public string prefix { get; set; }

        public byte number { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? modtime { get; set; }

        [StringLength(255)]
        public string position { get; set; }

        [StringLength(50)]
        public string size { get; set; }

        [Column(TypeName = "tinytext")]
        [StringLength(255)]
        public string remark { get; set; }

        [StringLength(255)]
        public string finaldestid { get; set; }
    }
}
