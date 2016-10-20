namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_tuan")]
    public partial class sline_tuan
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [StringLength(600)]
        public string title { get; set; }

        [StringLength(255)]
        public string shortname { get; set; }

        [StringLength(600)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? sellprice { get; set; }

        public int? price { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [Column(TypeName = "uint")]
        public long? starttime { get; set; }

        [Column(TypeName = "uint")]
        public long? endtime { get; set; }

        [Column(TypeName = "uint")]
        public long? bookcount { get; set; }

        [StringLength(16777215)]
        public string content { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string attrid { get; set; }

        [Column(TypeName = "uint")]
        public long? shownum { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [StringLength(50)]
        public string totalnum { get; set; }

        [StringLength(255)]
        public string virtualnum { get; set; }

        [StringLength(255)]
        public string validdate { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        [Column(TypeName = "uint")]
        public long? ishidden { get; set; }

        public int? jifenbook { get; set; }

        public int? jifentprice { get; set; }

        public int? jifencomment { get; set; }

        [StringLength(255)]
        public string sellpoint { get; set; }

        [StringLength(255)]
        public string dingjin { get; set; }

        public int? paytype { get; set; }

        [StringLength(255)]
        public string themelist { get; set; }

        [StringLength(255)]
        public string iconlist { get; set; }

        [StringLength(255)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        public int? satisfyscore { get; set; }

        public int? finaldestid { get; set; }
    }
}
