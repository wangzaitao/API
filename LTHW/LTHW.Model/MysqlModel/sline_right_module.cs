namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_right_module")]
    public partial class sline_right_module
    {
        [Key]
        public int moduleid { get; set; }

        [StringLength(30)]
        public string modulename { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public int? typeid { get; set; }

        public int pid { get; set; }
    }
}
