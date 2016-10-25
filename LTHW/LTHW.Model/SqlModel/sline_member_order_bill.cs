namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_member_order_bill")]
    public partial class sline_member_order_bill
    {
        [Key]
        [Column(" id")]
        public int C_id { get; set; }

        public int orderid { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Required]
        [StringLength(255)]
        public string receiver { get; set; }

        [Required]
        [StringLength(20)]
        public string mobile { get; set; }

        [Required]
        [StringLength(20)]
        public string province { get; set; }

        [Required]
        [StringLength(20)]
        public string city { get; set; }

        [Required]
        [StringLength(20)]
        public string address { get; set; }
    }
}
