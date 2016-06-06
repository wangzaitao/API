namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_visa_kind")]
    public partial class sline_visa_kind
    {
        public int id { get; set; }

        [StringLength(255)]
        public string kindname { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? isopen { get; set; }
    }
}
