namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_notes")]
    public partial class sline_notes
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long memberid { get; set; }

        [Required]
        [StringLength(150)]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
        public string bannerpic { get; set; }

        [Required]
        [StringLength(255)]
        public string litpic { get; set; }

        [Required]
        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string content { get; set; }

        [Column(TypeName = "uint")]
        public long shownum { get; set; }

        public int modtime { get; set; }

        public bool status { get; set; }

        [Required]
        [StringLength(255)]
        public string reason { get; set; }

        public int? audittime { get; set; }

        public int? addtime { get; set; }

        public short? displayorder { get; set; }

        public bool issend { get; set; }

        [Required]
        [StringLength(255)]
        public string kindlist { get; set; }

        [Required]
        [StringLength(255)]
        public string finaldestid { get; set; }
    }
}
