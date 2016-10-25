namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_weblist")]
    public partial class sline_weblist
    {
        public int id { get; set; }

        [StringLength(255)]
        public string webname { get; set; }

        [StringLength(255)]
        public string weburl { get; set; }

        public int? webid { get; set; }

        [StringLength(255)]
        public string webroot { get; set; }

        [StringLength(255)]
        public string webprefix { get; set; }
    }
}
