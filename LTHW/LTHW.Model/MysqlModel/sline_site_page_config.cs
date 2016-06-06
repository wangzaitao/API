namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_site_page_config")]
    public partial class sline_site_page_config
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? pageid { get; set; }

        [StringLength(255)]
        public string path { get; set; }

        public bool? isuse { get; set; }
    }
}
