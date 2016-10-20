namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_menu_quick")]
    public partial class sline_menu_quick
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int admin_id { get; set; }

        [Required]
        [StringLength(60)]
        public string menu_id { get; set; }
    }
}
