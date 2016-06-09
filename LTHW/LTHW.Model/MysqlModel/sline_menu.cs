namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_menu")]
    public partial class sline_menu
    {
        public int id { get; set; }

        public short pid { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
        public string entitle { get; set; }

        [StringLength(60)]
        public string controller { get; set; }

        [StringLength(60)]
        public string method { get; set; }

        [StringLength(255)]
        public string ico { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [StringLength(255)]
        public string extraparam { get; set; }

        public bool? extlink { get; set; }
    }
}
