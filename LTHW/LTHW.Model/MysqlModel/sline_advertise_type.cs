namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_advertise_type")]
    public partial class sline_advertise_type
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(255)]
        public string webid { get; set; }

        [StringLength(255)]
        public string position { get; set; }

        [StringLength(255)]
        public string tagname { get; set; }

        public int? width { get; set; }

        public int? height { get; set; }

        public int? type { get; set; }

        public int? issystem { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }
    }
}
