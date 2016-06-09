namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_line_booking")]
    public partial class sline_line_booking
    {
        public int id { get; set; }

        public int? webid { get; set; }

        public int? lineid { get; set; }

        [StringLength(255)]
        public string linename { get; set; }

        [StringLength(50)]
        public string dingdate { get; set; }

        [Column(TypeName = "uint")]
        public long? dingnum { get; set; }

        [StringLength(255)]
        public string dingname { get; set; }

        [StringLength(100)]
        public string dingtel { get; set; }

        public int? dingqq { get; set; }

        [StringLength(255)]
        public string dingemail { get; set; }

        [StringLength(800)]
        public string dingotherinfo { get; set; }

        public int? status { get; set; }

        public int? childnum { get; set; }

        [StringLength(10)]
        public string sex { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [StringLength(255)]
        public string ordersn { get; set; }

        [StringLength(255)]
        public string bianhao { get; set; }

        public int userid { get; set; }

        public decimal price { get; set; }
    }
}
