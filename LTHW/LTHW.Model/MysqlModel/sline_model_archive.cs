namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_model_archive")]
    public partial class sline_model_archive
    {
        public int id { get; set; }

        public int webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        [StringLength(1073741823)]
        public string content { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        [StringLength(255)]
        public string price { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        public int? shownum { get; set; }

        [StringLength(50)]
        public string tagword { get; set; }

        [StringLength(50)]
        public string keyword { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string themelist { get; set; }

        [StringLength(255)]
        public string attrid { get; set; }

        public sbyte? ishidden { get; set; }

        [StringLength(255)]
        public string iconlist { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        [StringLength(255)]
        public string satisfyscore { get; set; }

        [StringLength(255)]
        public string sellpoint { get; set; }

        [StringLength(255)]
        public string supplierlist { get; set; }

        public int? finaldestid { get; set; }
    }
}
