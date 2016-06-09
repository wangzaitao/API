namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_yqlj")]
    public partial class sline_yqlj
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [StringLength(50)]
        public string sitename { get; set; }

        [StringLength(255)]
        public string siteurl { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        public int? displayorder { get; set; }
    }
}
