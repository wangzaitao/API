namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_app")]
    public partial class sline_app
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string number { get; set; }

        [StringLength(50)]
        public string productcode { get; set; }

        public bool? status { get; set; }

        public bool? is_upgrade { get; set; }
    }
}
