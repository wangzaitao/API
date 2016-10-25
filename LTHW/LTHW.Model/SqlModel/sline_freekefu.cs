namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_freekefu")]
    public partial class sline_freekefu
    {
        public int id { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        public int? addtime { get; set; }

        [StringLength(255)]
        public string ip { get; set; }

        public bool? status { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? finishtime { get; set; }
    }
}
