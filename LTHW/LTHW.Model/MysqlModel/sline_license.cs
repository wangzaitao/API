namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_license")]
    public partial class sline_license
    {
        public int id { get; set; }

        public int? webid { get; set; }

        [StringLength(50)]
        public string licensename { get; set; }

        [StringLength(200)]
        public string litpic { get; set; }

        [StringLength(50)]
        public string displayorder { get; set; }

        [Column(TypeName = "uint")]
        public long? addtime { get; set; }

        [StringLength(255)]
        public string picurl { get; set; }

        [StringLength(255)]
        public string licenseurl { get; set; }
    }
}
