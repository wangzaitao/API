namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_tool_link")]
    public partial class sline_tool_link
    {
        public int id { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? type { get; set; }

        [StringLength(500)]
        public string linkurl { get; set; }

        public int? linelink { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [Column(TypeName = "uint")]
        public long? hotellink { get; set; }

        [Column(TypeName = "uint")]
        public long? carlink { get; set; }

        [Column(TypeName = "uint")]
        public long? articlelink { get; set; }

        [Column(TypeName = "uint")]
        public long? spotlink { get; set; }

        [Column(TypeName = "uint")]
        public long? photolink { get; set; }

        [Column(TypeName = "uint")]
        public long? visalink { get; set; }

        [Column(TypeName = "uint")]
        public long? questionlink { get; set; }

        [Column(TypeName = "uint")]
        public long? tuanlink { get; set; }
    }
}
