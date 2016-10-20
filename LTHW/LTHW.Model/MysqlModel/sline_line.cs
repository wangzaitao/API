namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_line")]
    public partial class sline_line
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(100)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string startcity { get; set; }

        [StringLength(255)]
        public string overcity { get; set; }

        [StringLength(255)]
        public string linedate { get; set; }

        public int? price { get; set; }

        public int? price_date { get; set; }

        [Column(TypeName = "uint")]
        public long? lineday { get; set; }

        public int? linenight { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string linedoc { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(1073741823)]
        public string jieshao { get; set; }

        [StringLength(1073741823)]
        public string biaozhun { get; set; }

        [StringLength(1073741823)]
        public string beizu { get; set; }

        [StringLength(1073741823)]
        public string payment { get; set; }

        [StringLength(1073741823)]
        public string feeinclude { get; set; }

        [StringLength(1073741823)]
        public string features { get; set; }

        [StringLength(700)]
        public string description { get; set; }

        public int? shownum { get; set; }

        public int? seatleft { get; set; }

        public int? storeprice { get; set; }

        [StringLength(1073741823)]
        public string transport { get; set; }

        public int? linebefore { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [StringLength(1073741823)]
        public string reserved1 { get; set; }

        [StringLength(1073741823)]
        public string reserved2 { get; set; }

        [StringLength(1073741823)]
        public string reserved3 { get; set; }

        [StringLength(255)]
        public string color { get; set; }

        [Required]
        [StringLength(255)]
        public string childrule { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string themelist { get; set; }

        [StringLength(255)]
        public string attrid { get; set; }

        public int? satisfyscore { get; set; }

        [Column(TypeName = "uint")]
        public long? bookcount { get; set; }

        public int? ishidden { get; set; }

        [StringLength(255)]
        public string isstyle { get; set; }

        [StringLength(255)]
        public string sellpoint { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        public int? distance { get; set; }

        [StringLength(255)]
        public string zijiaseat { get; set; }

        [StringLength(255)]
        public string zijiaprice { get; set; }

        [StringLength(255)]
        public string zijiacar { get; set; }

        public int? showrepast { get; set; }

        public int? paytype { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        [StringLength(255)]
        public string iconlist { get; set; }

        [StringLength(255)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string insuranceids { get; set; }

        [StringLength(50)]
        public string sourcelineid { get; set; }

        public bool? islinebefore { get; set; }

        public int? recommendnum { get; set; }

        public int? adminid { get; set; }

        public int? finaldestid { get; set; }
    }
}
