namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_visa_area")]
    public partial class sline_visa_area
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? pid { get; set; }

        [StringLength(255)]
        public string kindname { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? isopen { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(255)]
        public string bigpic { get; set; }

        [StringLength(255)]
        public string countrypic { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string jieshao { get; set; }

        [StringLength(255)]
        public string pinyin { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? ishot { get; set; }
    }
}
