namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_kindset")]
    public partial class sline_kindset
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }

        [StringLength(255)]
        public string aid { get; set; }

        [StringLength(255)]
        public string classid { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? istejia { get; set; }

        [Column(TypeName = "uint")]
        public long? isding { get; set; }

        [Column(TypeName = "uint")]
        public long? isjian { get; set; }
    }
}
