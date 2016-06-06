namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_line_spot")]
    public partial class sline_line_spot
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long webid { get; set; }

        [Column(TypeName = "uint")]
        public long? lineid { get; set; }

        [StringLength(255)]
        public string spotname { get; set; }

        public int? spotid { get; set; }

        [StringLength(16777215)]
        public string litpic { get; set; }

        public int? displayorder { get; set; }
    }
}
