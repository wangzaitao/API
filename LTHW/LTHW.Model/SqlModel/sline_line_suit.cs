namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_line_suit")]
    public partial class sline_line_suit
    {
        public int id { get; set; }

        public int lineid { get; set; }

        [StringLength(255)]
        public string suitname { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }

        public int? displayorder { get; set; }

        public int? jifenbook { get; set; }

        public int? jifentprice { get; set; }

        public int? jifencomment { get; set; }

        [StringLength(6)]
        public string propgroup { get; set; }

        public bool? paytype { get; set; }

        [StringLength(255)]
        public string dingjin { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string lastoffer { get; set; }
    }
}
