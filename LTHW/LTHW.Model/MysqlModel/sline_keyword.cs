namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_keyword")]
    public partial class sline_keyword
    {
        public int id { get; set; }

        public int? typeid { get; set; }

        [Column(TypeName = "char")]
        [StringLength(255)]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
        public string linkurl { get; set; }

        public int? webid { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        public int? aid { get; set; }
    }
}
