namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_attrorderlist")]
    public partial class sline_attrorderlist
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }

        [StringLength(255)]
        public string aid { get; set; }

        public int? classid { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? istejia { get; set; }

        [Column(TypeName = "uint")]
        public long? isding { get; set; }

        [Column(TypeName = "uint")]
        public long? isjian { get; set; }

        [StringLength(255)]
        public string destid { get; set; }
    }
}
