namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_spot")]
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

        public int? price { get; set; }

        public int? price_date { get; set; }

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

        [StringLength(200)]
        public string tagword { get; set; }

        [StringLength(200)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public double? lng { get; set; }

        public double? lat { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string themelist { get; set; }

        [StringLength(255)]
        public string attrid { get; set; }

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

        [StringLength(255)]
        public string iconlist { get; set; }

        public bool? ishidden { get; set; }

        public int? satisfyscore { get; set; }

        [StringLength(255)]
        public string bookcount { get; set; }

        [StringLength(255)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        public int? recommendnum { get; set; }

        public int? finaldestid { get; set; }
    }
}
