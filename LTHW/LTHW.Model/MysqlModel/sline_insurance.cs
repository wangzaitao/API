namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_insurance")]
    public partial class sline_insurance
    {
        public long id { get; set; }

        [StringLength(50)]
        public string companykey { get; set; }

        [StringLength(255)]
        public string productcode { get; set; }

        [StringLength(255)]
        public string productname { get; set; }

        public decimal? defaultprice { get; set; }

        public decimal? ourprice { get; set; }

        [StringLength(1073741823)]
        public string content { get; set; }
    }
}
