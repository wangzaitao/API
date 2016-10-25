namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_hotel")]
    public partial class sline_hotel
    {
        public int id { get; set; }

        public int webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(100)]
        public string seotitle { get; set; }

        [StringLength(255)]
        public string sellpoint { get; set; }

        public int? hotelrankid { get; set; }

        [StringLength(13)]
        public string telephone { get; set; }

        public int? postcode { get; set; }

        [StringLength(1073741823)]
        public string content { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        public int? price { get; set; }

        public int? price_date { get; set; }

        public int? shownum { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(1073741823)]
        public string description { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [StringLength(100)]
        public string litpic { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string themelist { get; set; }

        [StringLength(255)]
        public string attrid { get; set; }

        public int? ishidden { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string traffic { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string aroundspots { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string notice { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string equipment { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        [StringLength(255)]
        public string opentime { get; set; }

        [StringLength(255)]
        public string decoratetime { get; set; }

        [StringLength(255)]
        public string iconlist { get; set; }

        public int? satisfyscore { get; set; }

        [StringLength(5)]
        public string bookcount { get; set; }

        [StringLength(255)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        public int? recommendnum { get; set; }

        [StringLength(50)]
        public string lng { get; set; }

        [StringLength(50)]
        public string lat { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string fuwu { get; set; }

        public int? finaldestid { get; set; }
    }
}
