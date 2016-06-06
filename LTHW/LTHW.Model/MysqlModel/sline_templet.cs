namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_templet")]
    public partial class sline_templet
    {
        public int id { get; set; }

        [StringLength(30)]
        public string tempname { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? addtime { get; set; }

        [StringLength(255)]
        public string zippath { get; set; }
    }
}
