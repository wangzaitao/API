namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_icon")]
    public partial class sline_icon
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int? webid { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string kind { get; set; }

        [Required]
        [StringLength(255)]
        public string picurl { get; set; }
    }
}
