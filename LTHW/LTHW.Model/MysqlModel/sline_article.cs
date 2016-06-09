namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_article")]
    public partial class sline_article
    {
        public int id { get; set; }

        public int webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string comefrom { get; set; }

        [StringLength(70)]
        public string fromsite { get; set; }

        [StringLength(30)]
        public string author { get; set; }

        [StringLength(50)]
        public string kind { get; set; }

        [StringLength(1073741823)]
        public string content { get; set; }

        [StringLength(1073741823)]
        public string litpic { get; set; }

        public int? isindex { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        public int? shownum { get; set; }

        public int? isjian { get; set; }

        public int? isding { get; set; }

        [StringLength(50)]
        public string tagword { get; set; }

        [StringLength(50)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? displayorder { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string themelist { get; set; }

        [StringLength(255)]
        public string webidfs { get; set; }

        [StringLength(255)]
        public string attrid { get; set; }

        [StringLength(255)]
        public string childkind { get; set; }

        [StringLength(255)]
        public string allow { get; set; }

        public int? yesjian { get; set; }

        [StringLength(255)]
        public string ad_position { get; set; }

        [StringLength(255)]
        public string ad_typeid { get; set; }

        [StringLength(255)]
        public string ad_productid { get; set; }

        [StringLength(255)]
        public string ad_kindid { get; set; }

        [Column(TypeName = "uint")]
        public long? iscreat { get; set; }

        [StringLength(255)]
        public string redirecturl { get; set; }

        public sbyte? ishidden { get; set; }

        [StringLength(255)]
        public string iconlist { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        [StringLength(255)]
        public string summary { get; set; }

        [Column(TypeName = "uint")]
        public long? isoffical { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        [StringLength(255)]
        public string attachment { get; set; }

        [Column(TypeName = "uint")]
        public long? downnum { get; set; }

        public int? finaldestid { get; set; }
    }
}
