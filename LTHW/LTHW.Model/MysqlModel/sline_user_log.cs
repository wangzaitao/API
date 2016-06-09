namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_user_log")]
    public partial class sline_user_log
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long logtime { get; set; }

        [Column(TypeName = "uint")]
        public long uid { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(100)]
        public string loginfo { get; set; }

        [Required]
        [StringLength(100)]
        public string logip { get; set; }
    }
}
