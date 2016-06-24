namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("lthw.sline_region_province")]
    public partial class sline_region_province
    {
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string alias { get; set; }

        [StringLength(1073741823)]
        public string remark { get; set; }
    }
}
