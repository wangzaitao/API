namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_member_order_tourer")]
    public partial class sline_member_order_tourer
    {
        public int id { get; set; }

        [StringLength(255)]
        public string orderid { get; set; }

        [StringLength(255)]
        public string tourername { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string sex { get; set; }

        [StringLength(255)]
        public string cardtype { get; set; }

        [StringLength(255)]
        public string cardnumber { get; set; }

        [StringLength(15)]
        public string mobile { get; set; }
    }
}
