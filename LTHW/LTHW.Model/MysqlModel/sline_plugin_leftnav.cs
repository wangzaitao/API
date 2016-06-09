namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_plugin_leftnav")]
    public partial class sline_plugin_leftnav
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

        [StringLength(200)]
        public string litpic { get; set; }

        [StringLength(200)]
        public string remark { get; set; }
    }
}
