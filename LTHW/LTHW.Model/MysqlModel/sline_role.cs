namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_role")]
    public partial class sline_role
    {
        [Key]
        public int roleid { get; set; }

        [StringLength(20)]
        public string rolename { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public int? masterid { get; set; }

        public int? createdate { get; set; }

        public sbyte isoptn { get; set; }
    }
}
