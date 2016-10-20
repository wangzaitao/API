namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_region_city")]
    public partial class sline_region_city
    {
        public int id { get; set; }

        public int? provid { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(20)]
        public string zip { get; set; }

        public int? issubsite { get; set; }

        [StringLength(1073741823)]
        public string remark { get; set; }
    }
}
