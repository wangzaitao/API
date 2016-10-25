namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_sms_msg")]
    public partial class sline_sms_msg
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string msgtype { get; set; }

        [StringLength(255)]
        public string msg { get; set; }

        [Column(TypeName = "uint")]
        public long? isopen { get; set; }
    }
}
