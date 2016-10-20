namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_member_order_child")]
    public partial class sline_member_order_child
    {
        [Key]
        [Column(" id")]
        public int C_id { get; set; }

        public int? pid { get; set; }

        [StringLength(255)]
        public string ordersn { get; set; }

        public int? suitid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? dingnum { get; set; }

        public int? peoplenum { get; set; }

        public float? price { get; set; }

        public float? marketprice { get; set; }

        public sbyte? status { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string attachinfo { get; set; }

        public int? addtime { get; set; }
    }
}
