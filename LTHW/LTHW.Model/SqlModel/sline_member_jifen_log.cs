namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_member_jifen_log")]
    public partial class sline_member_jifen_log
    {
        public int id { get; set; }

        public int? memberid { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string content { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? type { get; set; }

        [Column(TypeName = "uint")]
        public long? jifen { get; set; }
    }
}
