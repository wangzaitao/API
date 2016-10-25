namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_region_county")]
    public partial class sline_region_county
    {
        public int id { get; set; }

        public int? cityid { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(1073741823)]
        public string remark { get; set; }
    }
}
