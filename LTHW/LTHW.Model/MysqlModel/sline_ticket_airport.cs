namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_ticket_airport")]
    public partial class sline_ticket_airport
    {
        public int id { get; set; }

        public int? destid { get; set; }

        [StringLength(255)]
        public string planename { get; set; }

        [Column(TypeName = "uint")]
        public long? isdefault { get; set; }

        [Column(TypeName = "uint")]
        public long? isopen { get; set; }

        public int? displayorder { get; set; }

        [StringLength(255)]
        public string domain { get; set; }
    }
}
