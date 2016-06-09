namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_plugin_nav")]
    public partial class sline_plugin_nav
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [StringLength(255)]
        public string kindname { get; set; }

        [Column(TypeName = "uint")]
        public long? pid { get; set; }

        [StringLength(255)]
        public string linkurl { get; set; }

        [StringLength(255)]
        public string color { get; set; }

        [Column(TypeName = "uint")]
        public long displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long isopen { get; set; }
    }
}
