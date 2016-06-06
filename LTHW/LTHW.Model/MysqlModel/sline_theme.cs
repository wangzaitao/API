namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_theme")]
    public partial class sline_theme
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string aid { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [StringLength(255)]
        public string ztname { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string shortname { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string logo { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string jieshao { get; set; }

        [StringLength(255)]
        public string bgcolor { get; set; }

        [StringLength(255)]
        public string bgimage { get; set; }

        [StringLength(255)]
        public string templetpath { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [Column(TypeName = "uint")]
        public long? shownum { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [StringLength(255)]
        public string modtime { get; set; }

        [Column(TypeName = "uint")]
        public long? isopen { get; set; }

        [StringLength(255)]
        public string templet { get; set; }
    }
}
