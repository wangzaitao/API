namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_model")]
    public partial class sline_model
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string modulename { get; set; }

        [StringLength(255)]
        public string pinyin { get; set; }

        [StringLength(255)]
        public string correct { get; set; }

        [StringLength(255)]
        public string maintable { get; set; }

        [StringLength(255)]
        public string addtable { get; set; }

        [StringLength(255)]
        public string attrtable { get; set; }

        public int? issystem { get; set; }

        public int? isopen { get; set; }
    }
}
