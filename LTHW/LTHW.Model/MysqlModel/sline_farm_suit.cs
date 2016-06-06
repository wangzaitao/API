namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_farm_suit")]
    public partial class sline_farm_suit
    {
        public int id { get; set; }

        public int webid { get; set; }

        public int? farmid { get; set; }

        [StringLength(255)]
        public string suitname { get; set; }

        [Column(TypeName = "uint")]
        public long? price { get; set; }

        [Column(TypeName = "uint")]
        public long? sellprice { get; set; }

        public int? displayorder { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string piclist { get; set; }

        public int? jifencomment { get; set; }

        public int? jifentprice { get; set; }

        public int? jifenbook { get; set; }

        [Column(TypeName = "uint")]
        public long? paytype { get; set; }

        [StringLength(255)]
        public string dingjin { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string lastoffer { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }
    }
}
