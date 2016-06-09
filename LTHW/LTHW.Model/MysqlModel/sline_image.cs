namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_image")]
    public partial class sline_image
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long group_id { get; set; }

        [StringLength(60)]
        public string image_name { get; set; }

        [Required]
        [StringLength(255)]
        public string url { get; set; }

        public int size { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string is_hidden { get; set; }
    }
}
