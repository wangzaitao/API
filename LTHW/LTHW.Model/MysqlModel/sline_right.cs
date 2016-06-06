namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_right")]
    public partial class sline_right
    {
        [Key]
        public int rightid { get; set; }

        [Required]
        [StringLength(20)]
        public string rightname { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? typid { get; set; }
    }
}
