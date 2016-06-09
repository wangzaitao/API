namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("lthw.sline_email_msg")]
    public partial class sline_email_msg
    {
        public int id { get; set; }

        [Column(TypeName = "char")]
        [StringLength(30)]
        public string msgtype { get; set; }

        [StringLength(255)]
        public string msg { get; set; }

        public bool isopen { get; set; }
    }
}
