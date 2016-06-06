namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_photo_picture")]
    public partial class sline_photo_picture
    {
        public int id { get; set; }

        public int? webid { get; set; }

        public int pid { get; set; }

        [StringLength(100)]
        public string litpic { get; set; }

        [StringLength(100)]
        public string bigpic { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        public int? isindex { get; set; }

        [Column(TypeName = "uint")]
        public long? modtime { get; set; }

        public int? displayorder { get; set; }
    }
}
