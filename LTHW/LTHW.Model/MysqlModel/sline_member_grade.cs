namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_member_grade")]
    public partial class sline_member_grade
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public int begin { get; set; }

        public int end { get; set; }

        public int displayorder { get; set; }

        public int addtime { get; set; }

        public int modtime { get; set; }
    }
}
