namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_ticket_booking")]
    public partial class sline_ticket_booking
    {
        public int id { get; set; }

        public int fatherid { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int ordernum { get; set; }

        public int planedate { get; set; }

        [Required]
        [StringLength(50)]
        public string cell { get; set; }

        [Required]
        [StringLength(50)]
        public string qqmsn { get; set; }

        [Required]
        [StringLength(50)]
        public string emaill { get; set; }

        [Column(TypeName = "uint")]
        public long status { get; set; }

        public int webid { get; set; }

        [StringLength(255)]
        public string ordersn { get; set; }

        [StringLength(255)]
        public string bianhao { get; set; }
    }
}
