namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_comment")]
    public partial class sline_comment
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }

        [Column(TypeName = "uint")]
        public long? orderid { get; set; }

        [StringLength(50)]
        public string articleid { get; set; }

        [Column(TypeName = "uint")]
        public long? memberid { get; set; }

        [Column(TypeName = "uint")]
        public long? pid { get; set; }

        [StringLength(16777215)]
        public string content { get; set; }

        [Column(TypeName = "uint")]
        public long? dockid { get; set; }

        public float? score1 { get; set; }

        public float? score2 { get; set; }

        public float? score3 { get; set; }

        public float? score4 { get; set; }

        public int? isshow { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? level { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }
    }
}
