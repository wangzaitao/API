namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_insurance_booking")]
    public partial class sline_insurance_booking
    {
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string bookordersn { get; set; }

        public int? booktype { get; set; }

        public long? memberid { get; set; }

        public int pid { get; set; }

        [StringLength(255)]
        public string productcasecode { get; set; }

        public sbyte type { get; set; }

        public int insurednum { get; set; }

        public float price { get; set; }

        public float? payprice { get; set; }

        public bool status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? applicationdate { get; set; }

        [Column(TypeName = "date")]
        public DateTime begindate { get; set; }

        [Column(TypeName = "date")]
        public DateTime enddate { get; set; }

        [StringLength(255)]
        public string destination { get; set; }

        [StringLength(100)]
        public string trippurposeid { get; set; }

        [StringLength(100)]
        public string visacity { get; set; }

        [Required]
        [StringLength(255)]
        public string ordersn { get; set; }

        [StringLength(255)]
        public string insureno { get; set; }

        [StringLength(255)]
        public string policyno { get; set; }

        [StringLength(255)]
        public string policyfileid { get; set; }

        public int? addtime { get; set; }

        public int? modtime { get; set; }

        public int? payedtime { get; set; }

        public bool? viewstatus { get; set; }
    }
}
