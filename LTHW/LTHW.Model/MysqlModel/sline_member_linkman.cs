namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_member_linkman")]
    public partial class sline_member_linkman
    {
        public int id { get; set; }

        public int? memberid { get; set; }

        [StringLength(250)]
        public string linkman { get; set; }

        [StringLength(11)]
        public string mobile { get; set; }

        [StringLength(20)]
        public string idcard { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string sex { get; set; }

        [StringLength(20)]
        public string cardtype { get; set; }
    }
}
