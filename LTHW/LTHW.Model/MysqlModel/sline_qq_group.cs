namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_qq_group")]
    public partial class sline_qq_group
    {
        public int id { get; set; }

        [StringLength(30)]
        public string groupname { get; set; }

        [StringLength(150)]
        public string groupdes { get; set; }

        public bool? isopen { get; set; }

        public int webid { get; set; }
    }
}
