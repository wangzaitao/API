namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_visa_booking")]
    public partial class sline_visa_booking
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        public int visaid { get; set; }

        [StringLength(255)]
        public string visaname { get; set; }

        [StringLength(100)]
        public string dingnum { get; set; }

        [StringLength(255)]
        public string price { get; set; }

        [StringLength(255)]
        public string info { get; set; }

        [StringLength(255)]
        public string dingname { get; set; }

        [StringLength(255)]
        public string dingtel { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        [Column(TypeName = "uint")]
        public long? status { get; set; }

        [StringLength(255)]
        public string ordersn { get; set; }

        [StringLength(255)]
        public string bianhao { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string qq { get; set; }
    }
}
