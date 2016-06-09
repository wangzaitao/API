namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_plugins")]
    public partial class sline_plugins
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string description { get; set; }

        [StringLength(255)]
        public string datatables { get; set; }

        [StringLength(255)]
        public string copyright { get; set; }

        [Column(TypeName = "uint")]
        public long? isopen { get; set; }

        [StringLength(255)]
        public string folder { get; set; }

        [StringLength(255)]
        public string identify { get; set; }
    }
}
