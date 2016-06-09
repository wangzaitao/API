namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_spot_ticket_type")]
    public partial class sline_spot_ticket_type
    {
        public int id { get; set; }

        [StringLength(255)]
        public string kindname { get; set; }

        [StringLength(255)]
        public string spotid { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [Column(TypeName = "uint")]
        public long? displayorder { get; set; }
    }
}
