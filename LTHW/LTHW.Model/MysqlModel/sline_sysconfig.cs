namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_sysconfig")]
    public partial class sline_sysconfig
    {
        public int id { get; set; }

        public int? webid { get; set; }

        [StringLength(30)]
        public string varname { get; set; }

        [StringLength(255)]
        public string info { get; set; }

        [StringLength(16777215)]
        public string value { get; set; }
    }
}
