namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_extend_field")]
    public partial class sline_extend_field
    {
        public int id { get; set; }

        public int typeid { get; set; }

        [Required]
        [StringLength(50)]
        public string fieldname { get; set; }

        [Required]
        [StringLength(50)]
        public string fieldtype { get; set; }

        [Required]
        [StringLength(50)]
        public string description { get; set; }

        [Required]
        [StringLength(255)]
        public string tips { get; set; }

        [Column(TypeName = "uint")]
        public long isopen { get; set; }

        [Column(TypeName = "uint")]
        public long addtime { get; set; }

        [Column(TypeName = "uint")]
        public long modtime { get; set; }

        [Column(TypeName = "uint")]
        public long isunique { get; set; }
    }
}
