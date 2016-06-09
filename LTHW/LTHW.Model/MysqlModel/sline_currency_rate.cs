namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_currency_rate")]
    public partial class sline_currency_rate
    {
        public int id { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string currencycode1 { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string currencycode2 { get; set; }

        public float? ratio1 { get; set; }

        public float? ratio2 { get; set; }
    }
}
