namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_article_gf")]
    public partial class sline_article_gf
    {
        public int id { get; set; }

        public int? pid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(16777215)]
        public string content { get; set; }

        public int? articleid { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }
    }
}
