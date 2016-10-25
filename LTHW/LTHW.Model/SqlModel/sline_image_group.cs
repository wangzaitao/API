namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_image_group")]
    public partial class sline_image_group
    {
        [Key]
        [Column(TypeName = "uint")]
        public long group_id { get; set; }

        [Required]
        [StringLength(60)]
        public string group_name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string do_not { get; set; }
    }
}
