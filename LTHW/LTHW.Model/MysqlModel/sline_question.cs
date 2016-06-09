namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_question")]
    public partial class sline_question
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }

        public int? productid { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content { get; set; }

        [StringLength(16777215)]
        public string replycontent { get; set; }

        [Column(TypeName = "uint")]
        public long? replytime { get; set; }

        [StringLength(25)]
        public string nickname { get; set; }

        [StringLength(23)]
        public string ip { get; set; }

        [Column(TypeName = "uint")]
        public long? status { get; set; }

        [Column(TypeName = "uint")]
        public long? memberid { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(50)]
        public string qq { get; set; }

        public int? webid { get; set; }

        [StringLength(255)]
        public string phone { get; set; }

        [StringLength(255)]
        public string weixin { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public bool? questype { get; set; }
    }
}
