namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_module_config")]
    public partial class sline_module_config
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [StringLength(255)]
        public string pagename { get; set; }

        [StringLength(255)]
        public string shortname { get; set; }

        [Column(TypeName = "uint")]
        public long? typeid { get; set; }

        [StringLength(255)]
        public string moduleids { get; set; }
    }
}
