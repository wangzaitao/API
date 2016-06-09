namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_tagword")]
    public partial class sline_tagword
    {
        public int id { get; set; }

        public int? webid { get; set; }

        public int? typeid { get; set; }

        [Column(TypeName = "char")]
        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        public int? aid { get; set; }
    }
}
