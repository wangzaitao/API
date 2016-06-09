namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_currency")]
    public partial class sline_currency
    {
        public int id { get; set; }

        [StringLength(100)]
        public string countryname { get; set; }

        [StringLength(100)]
        public string chinesename { get; set; }

        [StringLength(100)]
        public string englishname { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string code { get; set; }

        [StringLength(10)]
        public string symbol { get; set; }

        public bool? isopen { get; set; }
    }
}
