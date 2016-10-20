namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_line_dayspot")]
    public partial class sline_line_dayspot
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long webid { get; set; }

        [Column(TypeName = "uint")]
        public long? lineid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? spotid { get; set; }

        [StringLength(16777215)]
        public string litpic { get; set; }

        public int? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? day { get; set; }
    }
}
