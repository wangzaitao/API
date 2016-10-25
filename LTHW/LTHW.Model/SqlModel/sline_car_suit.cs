namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_car_suit")]
    public partial class sline_car_suit
    {
        public int id { get; set; }

        public int? carid { get; set; }

        [StringLength(255)]
        public string suitname { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content { get; set; }

        [StringLength(255)]
        public string unit { get; set; }

        public int? price { get; set; }

        public int? jifenbook { get; set; }

        public int? jifentprice { get; set; }

        public int? jifencomment { get; set; }

        [Column(TypeName = "uint")]
        public long? paytype { get; set; }

        [StringLength(255)]
        public string dingjin { get; set; }

        public int? suittypeid { get; set; }

        public int? displayorder { get; set; }

        public int? number { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string lastoffer { get; set; }
    }
}
