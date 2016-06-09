namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_qq_kefu")]
    public partial class sline_qq_kefu
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? pid { get; set; }

        [StringLength(50)]
        public string qqname { get; set; }

        [StringLength(20)]
        public string qqnum { get; set; }

        public sbyte? isopen { get; set; }

        public int? displayorder { get; set; }
    }
}
