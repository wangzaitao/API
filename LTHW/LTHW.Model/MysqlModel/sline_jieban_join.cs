namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_jieban_join")]
    public partial class sline_jieban_join
    {
        public int id { get; set; }

        public int jiebanid { get; set; }

        [StringLength(50)]
        public string linkman { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        public int? memberid { get; set; }

        public sbyte? adultnum { get; set; }

        public sbyte? childnum { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }
    }
}
