namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_visa")]
    public partial class sline_visa
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
        public string sellpoint { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [Required]
        [StringLength(255)]
        public string litpic { get; set; }

        [Column(TypeName = "uint")]
        public long? visatype { get; set; }

        [StringLength(255)]
        public string handleday { get; set; }

        [StringLength(255)]
        public string validday { get; set; }

        public int? needinterview { get; set; }

        [Column(TypeName = "uint")]
        public long? needletter { get; set; }

        [StringLength(255)]
        public string price { get; set; }

        [StringLength(255)]
        public string marketprice { get; set; }

        [StringLength(1073741823)]
        public string feeinclude { get; set; }

        [StringLength(1073741823)]
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

        [StringLength(255)]
        public string enternum { get; set; }

        [StringLength(1073741823)]
        public string specialtip { get; set; }

        [StringLength(1073741823)]
        public string bookingtip { get; set; }

        [StringLength(1073741823)]
        public string material1 { get; set; }

        [StringLength(1073741823)]
        public string material2 { get; set; }

        [StringLength(1073741823)]
        public string material3 { get; set; }

        [StringLength(1073741823)]
        public string material4 { get; set; }

        [StringLength(1073741823)]
        public string material5 { get; set; }

        public int? ishidden { get; set; }

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

        public int? recommendnum { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string attachment { get; set; }

        [StringLength(255)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        public int? cityid { get; set; }

        [StringLength(1073741823)]
        public string material { get; set; }

        [StringLength(1073741823)]
        public string booknotice { get; set; }

        [StringLength(1073741823)]
        public string circuit { get; set; }

        [StringLength(1073741823)]
        public string friendtip { get; set; }

        [Column(TypeName = "uint")]
        public long? paytype { get; set; }

        [StringLength(255)]
        public string dingjin { get; set; }

        public int? number { get; set; }
    }
}
