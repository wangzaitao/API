namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_destinations")]
    public partial class sline_destinations
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string kindname { get; set; }

        public int? pid { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string jieshao { get; set; }

        [Column(TypeName = "uint")]
        public long? kindtype { get; set; }

        [Column(TypeName = "uint")]
        public long? isopen { get; set; }

        [Column(TypeName = "uint")]
        public long isfinishseo { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? isnav { get; set; }

        [StringLength(255)]
        public string templetpath { get; set; }

        [Column(TypeName = "uint")]
        public long? ishot { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        public sbyte? istopnav { get; set; }

        [StringLength(255)]
        public string pinyin { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        public int? iswebsite { get; set; }

        [StringLength(50)]
        public string weburl { get; set; }

        [StringLength(50)]
        public string webroot { get; set; }

        [StringLength(50)]
        public string webprefix { get; set; }

        [StringLength(255)]
        public string opentypeids { get; set; }
    }
}
