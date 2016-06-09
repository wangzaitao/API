namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_line_extend")]
    public partial class sline_line_extend
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int lineid { get; set; }

        public int istemplets { get; set; }

        [Required]
        [StringLength(50)]
        public string relativeraider { get; set; }

        [Required]
        [StringLength(50)]
        public string relativehotel { get; set; }

        [Required]
        [StringLength(50)]
        public string relativeticket { get; set; }
    }
}
