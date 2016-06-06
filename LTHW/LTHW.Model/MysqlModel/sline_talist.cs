namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_talist")]
    public partial class sline_talist
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [StringLength(255)]
        public string tauser { get; set; }

        [StringLength(255)]
        public string face { get; set; }

        [StringLength(50)]
        public string nickname { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string education { get; set; }

        public int? jobtime { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string masterlines { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string product { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string profile { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string mycase { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        [StringLength(150)]
        public string msn { get; set; }

        [Required]
        [StringLength(255)]
        public string destinations { get; set; }

        [StringLength(255)]
        public string work { get; set; }

        public int? kind { get; set; }

        [StringLength(255)]
        public string linkname { get; set; }

        [StringLength(255)]
        public string phone { get; set; }

        [StringLength(255)]
        public string qq { get; set; }

        [StringLength(30)]
        public string email { get; set; }
    }
}
