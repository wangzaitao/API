namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_visa_")]
    public partial class sline_visa_
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(255)]
        public string visatype { get; set; }

        [StringLength(255)]
        public string handleday { get; set; }

        [StringLength(255)]
        public string validday { get; set; }

        [Column(TypeName = "uint")]
        public long? needinterview { get; set; }

        [Column(TypeName = "uint")]
        public long? needletter { get; set; }

        [StringLength(255)]
        public string price { get; set; }

        [StringLength(255)]
        public string marketprice { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string feeinclude { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content { get; set; }

        [StringLength(255)]
        public string handlerange { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [Column(TypeName = "uint")]
        public long? shownum { get; set; }

        [StringLength(255)]
        public string areaid { get; set; }

        [StringLength(255)]
        public string nationid { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [StringLength(255)]
        public string partday { get; set; }

        [StringLength(255)]
        public string acceptday { get; set; }

        [StringLength(255)]
        public string handlepeople { get; set; }

        [StringLength(255)]
        public string belongconsulate { get; set; }

        [Column(TypeName = "uint")]
        public long? cityid { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string booknotice { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string material { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string circuit { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string friendtip { get; set; }

        [StringLength(255)]
        public string dingjin { get; set; }

        public int? paytype { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string material1 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string material2 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string material3 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string material4 { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string material5 { get; set; }

        public sbyte? ishidden { get; set; }

        [StringLength(255)]
        public string satisfyscore { get; set; }

        [StringLength(255)]
        public string bookcount { get; set; }

        public int? jifenbook { get; set; }

        public int? jifentprice { get; set; }

        public int? jifencomment { get; set; }

        [StringLength(255)]
        public string iconlist { get; set; }

        [StringLength(255)]
        public string themelist { get; set; }

        [StringLength(255)]
        public string yesjian { get; set; }

        [StringLength(255)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string specialtip { get; set; }

        public int? enternum { get; set; }
    }
}
