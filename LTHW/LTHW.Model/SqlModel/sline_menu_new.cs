namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_menu_new")]
    public partial class sline_menu_new
    {
        public int id { get; set; }

        public int pid { get; set; }

        public sbyte? level { get; set; }

        public int? typeid { get; set; }

        [StringLength(60)]
        public string title { get; set; }

        [StringLength(60)]
        public string directory { get; set; }

        [StringLength(60)]
        public string controller { get; set; }

        [StringLength(60)]
        public string method { get; set; }

        [StringLength(20)]
        public string datainfo { get; set; }

        public bool? isshow { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }

        [StringLength(255)]
        public string extparams { get; set; }

        public bool? extlink { get; set; }
    }
}
