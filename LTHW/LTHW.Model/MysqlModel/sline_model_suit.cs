namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_model_suit")]
    public partial class sline_model_suit
    {
        public int id { get; set; }

        public int productid { get; set; }

        [StringLength(255)]
        public string suitname { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }

        public int? displayorder { get; set; }

        public int? jifenbook { get; set; }

        public int? jifentprice { get; set; }

        public int? jifencomment { get; set; }

        public bool? paytype { get; set; }

        public int? number { get; set; }

        [StringLength(255)]
        public string dingjin { get; set; }

        [StringLength(255)]
        public string sellprice { get; set; }

        [StringLength(255)]
        public string ourprice { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string lastoffer { get; set; }
    }
}
