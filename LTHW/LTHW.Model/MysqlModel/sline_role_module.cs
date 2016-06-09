namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_role_module")]
    public partial class sline_role_module
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roleid { get; set; }

        [Column(TypeName = "char")]
        [StringLength(15)]
        public string moduleid { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool slook { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool smodify { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool sadd { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool sdelete { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool sall { get; set; }
    }
}
