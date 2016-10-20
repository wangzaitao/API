namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_insurance_booking_tourer")]
    public partial class sline_insurance_booking_tourer
    {
        public long id { get; set; }

        public int orderid { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string pinyin { get; set; }

        public bool sex { get; set; }

        [StringLength(5)]
        public string cardtype { get; set; }

        [StringLength(255)]
        public string cardcode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [StringLength(10)]
        public string jobcode { get; set; }

        public sbyte? joblevel { get; set; }

        [StringLength(100)]
        public string job { get; set; }

        [StringLength(100)]
        public string fltno { get; set; }

        [StringLength(100)]
        public string city { get; set; }

        [StringLength(20)]
        public string insurantrelation { get; set; }

        public int? count { get; set; }
    }
}
