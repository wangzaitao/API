namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_nav")]
    public partial class sline_nav
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        public int? typeid { get; set; }

        [Column(TypeName = "usmallint")]
        public int? pid { get; set; }

        [StringLength(255)]
        public string typename { get; set; }

        [StringLength(255)]
        public string shortname { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(16777215)]
        public string jieshao { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [StringLength(255)]
        public string url { get; set; }

        public int? linktype { get; set; }

        public int? isopen { get; set; }

        public int? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? issystem { get; set; }

        [StringLength(255)]
        public string linktitle { get; set; }

        [Column(TypeName = "uint")]
        public long? isfinishseo { get; set; }

        public int? shownum { get; set; }

        [StringLength(255)]
        public string templetpath { get; set; }

        public sbyte? kind { get; set; }
    }
}
