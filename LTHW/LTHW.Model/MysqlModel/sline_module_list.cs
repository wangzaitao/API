namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_module_list")]
    public partial class sline_module_list
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? aid { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [StringLength(255)]
        public string modulename { get; set; }

        [StringLength(16777215)]
        public string body { get; set; }

        [Column(TypeName = "uint")]
        public long? issystem { get; set; }

        public int? type { get; set; }

        public int? version { get; set; }
    }
}
