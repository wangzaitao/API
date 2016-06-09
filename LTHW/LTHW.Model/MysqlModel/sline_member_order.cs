namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_member_order")]
    public partial class sline_member_order
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string ordersn { get; set; }

        [Column(TypeName = "uint")]
        public long? memberid { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? productaid { get; set; }

        [StringLength(255)]
        public string productname { get; set; }

        [Column(TypeName = "uint")]
        public long? productautoid { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(255)]
        public string usedate { get; set; }

        [Column(TypeName = "uint")]
        public long? dingnum { get; set; }

        [Column(TypeName = "uint")]
        public long? childnum { get; set; }

        [Column(TypeName = "uint")]
        public long? ispay { get; set; }

        [Column(TypeName = "uint")]
        public long? status { get; set; }

        [StringLength(255)]
        public string linkman { get; set; }

        [StringLength(255)]
        public string linktel { get; set; }

        [StringLength(100)]
        public string linkemail { get; set; }

        [StringLength(16)]
        public string linkqq { get; set; }

        [StringLength(20)]
        public string linkidcard { get; set; }

        [Column(TypeName = "uint")]
        public long? isneedpiao { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? finishtime { get; set; }

        [Column(TypeName = "uint")]
        public long? ispinlun { get; set; }

        public int? jifencomment { get; set; }

        public int? jifentprice { get; set; }

        public int? jifenbook { get; set; }

        public float? dingjin { get; set; }

        public int? suitid { get; set; }

        public int? paytype { get; set; }

        public int? oldnum { get; set; }

        public float? oldprice { get; set; }

        [Column(TypeName = "uint")]
        public long? usejifen { get; set; }

        [Column(TypeName = "uint")]
        public long? needjifen { get; set; }

        public int? pid { get; set; }

        [Column(TypeName = "uint")]
        public long? haschild { get; set; }

        [StringLength(16777215)]
        public string remark { get; set; }

        [StringLength(255)]
        public string kindlist { get; set; }

        public bool? viewstatus { get; set; }

        public int? roombalance { get; set; }

        public int? roombalancenum { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string paysource { get; set; }

        [StringLength(255)]
        public string departdate { get; set; }

        public bool? roombalance_paytype { get; set; }

        [StringLength(50)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string distributor { get; set; }

        public float? marketprice { get; set; }

        public float? spotprice { get; set; }

        public float? distributorprice { get; set; }

        public float? eticketno { get; set; }

        [Column(TypeName = "uint")]
        public long? isconsume { get; set; }

        public int? consumetime { get; set; }

        public int? consumeverifyuser { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string consumeverifymemo { get; set; }

        [StringLength(1073741823)]
        public string distributororderexdata { get; set; }

        [StringLength(1073741823)]
        public string supplierorderexdata { get; set; }
    }
}
