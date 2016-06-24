namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("lthw.sline_member_address")]
    public partial class sline_member_address
    {
        public int id { get; set; }

        public int mid { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string mobile { get; set; }

        public int? provid { get; set; }

        [StringLength(50)]
        public string province { get; set; }

        public int? cityid { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        public int? countyid { get; set; }

        [StringLength(50)]
        public string county { get; set; }

        [StringLength(100)]
        public string addresshome { get; set; }

        [StringLength(20)]
        public string zip { get; set; }

        public int? isdefault { get; set; }

        public int? flag { get; set; }
    }
}
