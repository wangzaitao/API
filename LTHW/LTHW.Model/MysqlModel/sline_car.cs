namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_car")]
    public partial class sline_car
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? seatnum { get; set; }

        public int? maxseatnum { get; set; }

        [StringLength(255)]
        public string sellpoint { get; set; }

        public int? displayorder { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(1073741823)]
        public string content { get; set; }

        public int? shownum { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [StringLength(255)]
        public string tagword { get; set; }

        [StringLength(255)]
        public string keyword { get; set; }

        [StringLength(1073741823)]
        public string description { get; set; }

        [StringLength(255)]
        public string carbrand { get; set; }

        public int? isjian { get; set; }

        public int? isding { get; set; }

        public int? istejia { get; set; }

        [StringLength(255)]
        public string seotitle { get; set; }

        public int? carkindid { get; set; }

        public int? carbrandid { get; set; }

        [StringLength(255)]
        public string caralt { get; set; }

        public int? recommendnum { get; set; }

        public int? funrecommend { get; set; }

        public int? usedyears { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        [StringLength(255)]
        public string themelist { get; set; }

        [StringLength(255)]
        public string webidfs { get; set; }

        [StringLength(50)]
        public string attrid { get; set; }

        public int? ishidden { get; set; }

        [StringLength(255)]
        public string unit { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        public int? startplaceid { get; set; }

        public int? tanknum { get; set; }

        [StringLength(30)]
        public string phone { get; set; }

        [StringLength(16777215)]
        public string notice { get; set; }

        [StringLength(255)]
        public string iconlist { get; set; }

        [StringLength(11)]
        public string satisfyscore { get; set; }

        [StringLength(11)]
        public string bookcount { get; set; }

        [StringLength(255)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string templet { get; set; }

        public int? price { get; set; }

        public int? finaldestid { get; set; }
    }
}
