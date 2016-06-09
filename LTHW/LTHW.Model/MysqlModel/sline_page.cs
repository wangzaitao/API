namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_page")]
    public partial class sline_page
    {
        public int id { get; set; }

        [StringLength(255)]
        public string pid { get; set; }

        [StringLength(255)]
        public string kindname { get; set; }

        [StringLength(255)]
        public string pagename { get; set; }
    }
}
