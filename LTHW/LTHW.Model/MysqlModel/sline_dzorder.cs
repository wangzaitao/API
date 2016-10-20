namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_dzorder")]
    public partial class sline_dzorder
    {
        public int id { get; set; }

        [StringLength(255)]
        public string ordersn { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? dingjin { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        [StringLength(255)]
        public string phone { get; set; }

        public int? travelnum { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }

        public int? addtime { get; set; }

        public int? finishtime { get; set; }

        public int? status { get; set; }

        public bool? viewstatus { get; set; }

        [Column(TypeName = "char")]
        [StringLength(50)]
        public string paysource { get; set; }
    }
}
