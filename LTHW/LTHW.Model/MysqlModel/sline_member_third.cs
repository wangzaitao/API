namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_member_third")]
    public partial class sline_member_third
    {
        public int id { get; set; }

        public int mid { get; set; }

        [Required]
        [StringLength(255)]
        public string openid { get; set; }

        [Required]
        [StringLength(100)]
        public string from { get; set; }

        [StringLength(100)]
        public string nickname { get; set; }
    }
}
