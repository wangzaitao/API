namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_model_content")]
    public partial class sline_model_content
    {
        public int id { get; set; }

        public int? webid { get; set; }

        public int? typeid { get; set; }

        [StringLength(30)]
        public string columnname { get; set; }

        [StringLength(100)]
        public string chinesename { get; set; }

        public int? displayorder { get; set; }

        public int? issystem { get; set; }

        public int? isopen { get; set; }

        public int? isline { get; set; }

        public bool? isrealfield { get; set; }
    }
}
