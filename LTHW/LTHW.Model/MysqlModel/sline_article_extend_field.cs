namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_article_extend_field")]
    public partial class sline_article_extend_field
    {
        public int id { get; set; }

        public int? productid { get; set; }
    }
}
