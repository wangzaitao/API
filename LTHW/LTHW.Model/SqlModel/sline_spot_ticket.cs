namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_spot_ticket")]
    public partial class sline_spot_ticket
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? spotid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [Column(TypeName = "uint")]
        public long? tickettypeid { get; set; }

        [StringLength(255)]
        public string sellprice { get; set; }

        [StringLength(255)]
        public string ourprice { get; set; }

        [StringLength(255)]
        public string memberdayprice { get; set; }

        [StringLength(255)]
        public string paytype { get; set; }

        [Column(TypeName = "uint")]
        public long? award { get; set; }

        [StringLength(5000)]
        public string description { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        public int? number { get; set; }

        [StringLength(255)]
        public string bnum { get; set; }

        [StringLength(255)]
        public string mnum { get; set; }

        public int? buylimitnummin { get; set; }

        public int? buylimitnummax { get; set; }

        public int? iscanrefund { get; set; }

        public int? refundBeforeValidEndDay { get; set; }

        [StringLength(500)]
        public string refundInfo { get; set; }

        [StringLength(50)]
        public string eticketType { get; set; }

        [StringLength(255)]
        public string eticketsmssign { get; set; }

        [StringLength(1000)]
        public string eticketsmstemplet { get; set; }

        [StringLength(255)]
        public string startdate { get; set; }

        [StringLength(255)]
        public string enddate { get; set; }

        public int? jifencomment { get; set; }

        public int? jifentprice { get; set; }

        public int? jifenbook { get; set; }

        [StringLength(255)]
        public string dingjin { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string lastoffer { get; set; }
    }
}
