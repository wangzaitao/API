namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_feedback")]
    public partial class sline_feedback
    {
        public int id { get; set; }

        [StringLength(255)]
        public string uname { get; set; }

        [StringLength(20)]
        public string mobile { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }
    }
}
