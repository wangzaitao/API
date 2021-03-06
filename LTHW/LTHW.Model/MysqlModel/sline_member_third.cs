namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_member_third")]
    public partial class sline_member_third
    {
        public int id { get; set; }

        public int mid { get; set; }

        [Required]
        [StringLength(255)]
        public string openid { get; set; }

        [Required]
        [StringLength(100)]
        public string from { get; set; }

        [StringLength(100)]
        public string nickname { get; set; }

        [StringLength(500)]
        public string headimgurl { get; set; }

        public DateTime? subscribetime { get; set; }

        public DateTime? unsubscribetime { get; set; }

        public int? status { get; set; }
    }
}
