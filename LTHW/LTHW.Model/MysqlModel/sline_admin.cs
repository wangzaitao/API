namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_admin")]
    public partial class sline_admin
    {
        public int id { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string sxw_name { get; set; }

        [Column(TypeName = "uint")]
        public long? logintime { get; set; }

        [StringLength(255)]
        public string loginip { get; set; }

        public int? roleid { get; set; }

        [StringLength(30)]
        public string realname { get; set; }

        [StringLength(500)]
        public string beizu { get; set; }

        [Required]
        [StringLength(255)]
        public string litpic { get; set; }
    }
}
