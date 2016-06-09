namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_allorderlist")]
    public partial class sline_allorderlist
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }

        public int? aid { get; set; }

        public int? classid { get; set; }

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
