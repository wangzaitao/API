namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_line_jieshao")]
    public partial class sline_line_jieshao
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? lineid { get; set; }

        [Column(TypeName = "uint")]
        public long? day { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public bool? breakfirsthas { get; set; }

        [StringLength(255)]
        public string breakfirst { get; set; }

        [StringLength(255)]
        public string transport { get; set; }

        [StringLength(255)]
        public string hotel { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string jieshao { get; set; }

        public bool? lunchhas { get; set; }

        [StringLength(255)]
        public string lunch { get; set; }

        public bool? supperhas { get; set; }

        [StringLength(255)]
        public string supper { get; set; }
    }
}
