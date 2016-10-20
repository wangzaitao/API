namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_supplier_kind")]
    public partial class sline_supplier_kind
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string kindname { get; set; }

        public bool? isopen { get; set; }

        [Column(TypeName = "uint")]
        public long? pid { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [StringLength(255)]
        public string path { get; set; }
    }
}
