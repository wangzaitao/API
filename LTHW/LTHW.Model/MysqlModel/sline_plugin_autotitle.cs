namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_plugin_autotitle")]
    public partial class sline_plugin_autotitle
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string value { get; set; }
    }
}
