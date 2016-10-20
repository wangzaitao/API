namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_hotel_attr")]
    public partial class sline_hotel_attr
    {
        public int id { get; set; }

        [Column(TypeName = "uint")]
        public long? webid { get; set; }

        [StringLength(255)]
        public string attrname { get; set; }

        public int? displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? isopen { get; set; }

        public int? pid { get; set; }

        [Column(TypeName = "uint")]
        public long? issystem { get; set; }

        [StringLength(255)]
        public string destid { get; set; }

        [StringLength(255)]
        public string litpic { get; set; }

        [StringLength(255)]
        public string description { get; set; }
    }
}
