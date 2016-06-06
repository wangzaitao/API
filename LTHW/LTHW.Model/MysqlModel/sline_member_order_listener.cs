namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_member_order_listener")]
    public partial class sline_member_order_listener
    {
        public int id { get; set; }

        public int? webid { get; set; }

        public int? typeid { get; set; }

        [StringLength(50)]
        public string supplierlist { get; set; }

        [StringLength(255)]
        public string distributor { get; set; }

        public int? productautoid { get; set; }

        public int? suitid { get; set; }

        public int? order_status { get; set; }

        [Required]
        [StringLength(5000)]
        public string execute_url { get; set; }

        [StringLength(1073741823)]
        public string exdata { get; set; }

        public int isenabled { get; set; }
    }
}
