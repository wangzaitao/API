namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_spot")]
    public partial class sline_spot
    {
        public int id { get; set; }

        public int webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(20)]
        public string shortname { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        public int isspotarea { get; set; }

        public int? lineclass { get; set; }

        public int? price { get; set; }

        [StringLength(40)]
        public string area { get; set; }

        [StringLength(200)]
        public string spotpicid { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(1073741823)]
        public string content { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        public int? shownum { get; set; }

        [StringLength(20)]
        public string author { get; set; }

        [StringLength(255)]
        public string went { get; set; }

        [StringLength(255)]
        public string want { get; set; }

        public int? isjian { get; set; }

        public int? isding { get; set; }

        [StringLength(200)]
        public string tagword { get; set; }

        [StringLength(200)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public double? lng { get; set; }

        public double? lat { get; set; }

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

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string booknotice { get; set; }

        [StringLength(255)]
        public string friendtip { get; set; }

        [StringLength(255)]
        public string getway { get; set; }

        [StringLength(255)]
        public string sellpoint { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        public int? dingjin { get; set; }

        [StringLength(255)]
        public string iconlist { get; set; }

        public bool? ishidden { get; set; }

        [StringLength(255)]
        public string satisfyscore { get; set; }

        public int? recommendnum { get; set; }

        [StringLength(255)]
        public string bookcount { get; set; }

        [StringLength(255)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        public int? finaldestid { get; set; }
    }
}
