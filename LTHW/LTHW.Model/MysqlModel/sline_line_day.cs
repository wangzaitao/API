namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_line_day")]
    public partial class sline_line_day
    {
        public int id { get; set; }

        public int? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [Column(TypeName = "uint")]
        public long? word { get; set; }

        [Column(TypeName = "uint")]
        public long? isdisplay { get; set; }
    }
}
