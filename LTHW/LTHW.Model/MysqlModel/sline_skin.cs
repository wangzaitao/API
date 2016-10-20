namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_skin")]
    public partial class sline_skin
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

        [Required]
        [StringLength(50)]
        public string main_color { get; set; }

        [Required]
        [StringLength(50)]
        public string icon_color { get; set; }

        [Required]
        [StringLength(50)]
        public string line_color { get; set; }

        [Required]
        [StringLength(50)]
        public string font_color { get; set; }

        [Required]
        [StringLength(50)]
        public string font_hover_color { get; set; }

        [Required]
        [StringLength(50)]
        public string nav_color { get; set; }

        [Required]
        [StringLength(50)]
        public string nav_hover_color { get; set; }

        [Required]
        [StringLength(50)]
        public string footer_level_color { get; set; }

        [Required]
        [StringLength(50)]
        public string usernav_color { get; set; }

        public int is_system { get; set; }
    }
}
