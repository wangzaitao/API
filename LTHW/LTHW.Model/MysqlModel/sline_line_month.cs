namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_line_month")]
    public partial class sline_line_month
    {
        public int id { get; set; }

        public int? webid { get; set; }

        public int? lineid { get; set; }

        public int? yearnum { get; set; }

        [StringLength(255)]
        public string monthnum { get; set; }

        [Required]
        [StringLength(50)]
        public string exname { get; set; }

        [Required]
        [StringLength(50)]
        public string exchange { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string basicprice { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string profit { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string price { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string description { get; set; }
    }
}
