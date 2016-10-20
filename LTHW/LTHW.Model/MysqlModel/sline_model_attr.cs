namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_model_attr")]
    public partial class sline_model_attr
    {
        public int id { get; set; }

        public int webid { get; set; }

        public int typeid { get; set; }

        [StringLength(255)]
        public string attrname { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? isopen { get; set; }

        [Column(TypeName = "uint")]
        public long? issystem { get; set; }

        public int? pid { get; set; }

        [StringLength(255)]
        public string destid { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(255)]
        public string description { get; set; }
    }
}
