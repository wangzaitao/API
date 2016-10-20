namespace LTHW.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("stourwebcms.sline_role_right")]
    public partial class sline_role_right
    {
        public int id { get; set; }

        public int? roleid { get; set; }

        public int? menuid { get; set; }

        public bool? right { get; set; }
    }
}
